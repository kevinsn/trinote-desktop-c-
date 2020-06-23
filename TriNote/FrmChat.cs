using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace TriNote
{
    public partial class FrmChat : Form
    {
        // Variáveis globais
        String nomeFuncionario;
        String nomeUsuario;
        int idFuncionario;
        int idUsuario;
        int idSolicitacao;
        int quantidade;
        int tipoChat;
        Timer timer;

        DateTime horaAtual;
        string horaAtualSql;

        //tipoChat: 
        //1 = chat em tempo real
        //2 = chats em aberto (chamados)
        //3 = chats finalizados (histórico)

        Conexao conexao;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        // Construtor tem como parâmetro o idFuncionário e o tipoChat 
        // em tempo real, chamado ou chat fechado (histórico)      
        public FrmChat(int id, int tipoChat)
        {
            InitializeComponent();
            idFuncionario = id;
            this.tipoChat = tipoChat;
        }

        // FrmChat_Load, assim que carrega inicia o timer e carrega o nomeFuncionário
        private void FrmChat_Load(object sender, EventArgs e)
        {
            if (tipoChat == 2)
            {
                lblTitulo.Text = "Atendimentos em aberto";
            }

            if (tipoChat == 3)
            {
                txtEnvia.Enabled = false;
                btnEnviar.Enabled = false;
                lblTitulo.Text = "Histórico";
            }

            timer = new Timer();
            timer.Interval = (5 * 1000);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            conexao = new Conexao();
            conexao.conectar();
            conexao.command.CommandText = "select * from Funcionario where idFuncionario=@idFuncionario";
            conexao.command.Parameters.Add("@idFuncionario", SqlDbType.Int).Value = idFuncionario;
            conexao.command.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();
            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            nomeFuncionario = dataSet.Tables[0].Rows[0]["nomeFuncionario"].ToString();
        }

        // Timer que verifica se tem algum usuário na lista de espera 
        // ou se tem nova mensagem para atualizar o chat em tempo real
        private void timer_Tick(object sender, EventArgs e)
        {
            // Refresh
            // MessageBox.Show("Estou no timer");

            if (lstFilaEspera.Focused == false) // Se tiver em foco, não atualiza
            {
                atualizarListaEspera(tipoChat);
            }

            if (txtRecebe.Focused == false && idSolicitacao != 0)
            {
                atualizarMensagens();
            }
        }

        // Método atualizarListaEspera() checa o tipo de chat e adiciona o usuário na lista de espera
        private void atualizarListaEspera(int tipoChat)
        {
            // MessageBox.Show("Estou no atualizar ListaEspera");

            conexao = new Conexao();

            if (tipoChat == 1)
            {
                conexao.sql = "select Usuario.nomeUsuario, Usuario.idUsuario, Solicitacao.idSolicitacao, Solicitacao.motivo from Usuario,Solicitacao where Usuario.nomeUsuario = Usuario.nomeUsuario and Usuario.idUsuario = Solicitacao.idUsuario and Solicitacao.emEspera = 1";

            }
            else if (tipoChat == 2)
            {
                conexao.sql = "select Usuario.nomeUsuario, Usuario.idUsuario, Solicitacao.idSolicitacao, Solicitacao.motivo from Usuario,Solicitacao where Usuario.nomeUsuario = Usuario.nomeUsuario and Usuario.idUsuario = Solicitacao.idUsuario and Solicitacao.emEspera = 0 and Solicitacao.dataHoraTerminoSol > '2000-01-01 00:00:00.000' and Solicitacao.emAberto = 1";

            }
            else if (tipoChat == 3)
            {
                conexao.sql = "select Usuario.nomeUsuario, Usuario.idUsuario, Solicitacao.idSolicitacao, Solicitacao.motivo from Usuario,Solicitacao where Usuario.nomeUsuario = Usuario.nomeUsuario and Usuario.idUsuario = Solicitacao.idUsuario and Solicitacao.emEspera = 0 and Solicitacao.dataHoraTerminoSol > '2000-01-01 00:00:00.000' and Solicitacao.emAberto = 0";

            }

            conexao.ler();

            lstFilaEspera.Items.Clear();

            while (conexao.reader.Read())
            {
                ListViewItem lv = new ListViewItem(conexao.reader.GetString(0));
                lv.SubItems.Add(conexao.reader.GetInt32(1).ToString());
                lv.SubItems.Add(conexao.reader.GetInt32(2).ToString());
                lv.SubItems.Add(conexao.reader.GetString(3).ToString());
                lstFilaEspera.Items.Add(lv);
                // MessageBox.Show(conexao.reader.GetInt32(0).ToString());
                // MessageBox.Show(conexao.reader.GetString(1));

            }

            conexao.reader.Close();
            conexao.fechaConexao();
        }

        // Método atualizarMensagens() busca as mensagens de acordo com o ID da solicitação e ordena por data
        // quantidade se refere a quantidade de mensagens       
        private void atualizarMensagens()
        {
            conexao = new Conexao();
            conexao.conectar();
            conexao.command.CommandText = "select * from Mensagem where idSolicitacao=@idSolicitacao order by dataHoraMensagem";
            conexao.command.Parameters.Add("@idSolicitacao", SqlDbType.Int).Value = idSolicitacao;
            conexao.command.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();
            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            quantidade = dataSet.Tables[0].DefaultView.Count;
            txtRecebe.Clear();

            for (int x = 0; x < quantidade; x++)
            {
                if (Convert.ToBoolean(dataSet.Tables[0].Rows[x]["isUsuario"]) == true)
                    txtRecebe.Text += "[" + nomeUsuario + "]: " + dataSet.Tables[0].Rows[x]["txtMensagem"].ToString() + "\n\n";
                else
                    txtRecebe.Text += "[" + nomeFuncionario + "]: " + dataSet.Tables[0].Rows[x]["txtMensagem"].ToString() + "\n\n";
            }
            
            txtRecebe.SelectionStart = txtRecebe.TextLength;
            txtRecebe.ScrollToCaret();

            quantidade = 0;

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (lstEmAtendimento.Items.Count > 0)
            {
                conexao = new Conexao();
                conexao.conectar();
                txtRecebe.Text += "[" + nomeFuncionario + "]: " + txtEnvia.Text + "\n\n";
                horaAtual = DateTime.Now;
                horaAtualSql = horaAtual.ToString("yyyy-MM-dd HH:mm:ss.fff");
                conexao.command.CommandText = "insert into Mensagem (idSolicitacao,idFuncionario,isUsuario,txtMensagem,dataHoraMensagem) values (@idSolicitacao, @idFuncionario, 0, @txtMensagem, @dataHoraMensagem)";
                conexao.command.Parameters.Add("@idSolicitacao", SqlDbType.Int).Value = idSolicitacao;
                conexao.command.Parameters.Add("@idFuncionario", SqlDbType.Int).Value = idFuncionario;
                conexao.command.Parameters.Add("@txtMensagem", SqlDbType.VarChar).Value = txtEnvia.Text;
                conexao.command.Parameters.Add("@dataHoraMensagem", SqlDbType.DateTime).Value = horaAtualSql;
                conexao.command.ExecuteNonQuery();
                txtEnvia.Clear();
                conexao.fechaConexao();
            }
        }

        private void lstFilaEspera_DoubleClick(object sender, EventArgs e)
        {
            if (lstEmAtendimento.Items.Count < 8)
            {
                nomeUsuario = lstFilaEspera.SelectedItems[0].SubItems[0].Text;
                idUsuario = Convert.ToInt32(lstFilaEspera.SelectedItems[0].SubItems[1].Text);
                idSolicitacao = Convert.ToInt32(lstFilaEspera.SelectedItems[0].SubItems[2].Text);

                conexao = new Conexao();
                conexao.conectar();
                conexao.command.CommandText = "select * from Usuario where idUsuario=@idUsuario";
                conexao.command.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario; 
                conexao.command.ExecuteNonQuery();
                conexao.fechaConexao();

                ListViewItem lv = new ListViewItem(lstFilaEspera.SelectedItems[0].Text);
                lv.SubItems.Add(lstFilaEspera.SelectedItems[0].SubItems[1].Text);
                lv.SubItems.Add(lstFilaEspera.SelectedItems[0].SubItems[2].Text);
                lstEmAtendimento.Items.Add(lv);

                // dataAdapter = new SqlDataAdapter();
                // dataSet = new DataSet();

                conexao = new Conexao();
                conexao.conectar();

                if (tipoChat == 1)
                {
                    conexao.command.CommandText = "update Solicitacao set emEspera = 0 where idUsuario=@idUsuario";
                    conexao.command.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                }
                else
                {
                    conexao.command.CommandText = "update Solicitacao set dataHoraTerminoSol = null where idUsuario=@idUsuario";
                    conexao.command.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                }

                conexao.command.ExecuteNonQuery();
                conexao.fechaConexao();

                atualizarMensagens();

                foreach (ListViewItem eachItem in lstFilaEspera.SelectedItems)
                {
                    lstFilaEspera.Items.Remove(eachItem);
                }
            }           

        }

        private void lstEmAtendimento_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("idUsuario= " + idUsuario + "idSolicitacao= " +idSolicitacao);
            nomeUsuario = lstEmAtendimento.SelectedItems[0].SubItems[0].Text;
            idSolicitacao = Convert.ToInt32(lstEmAtendimento.SelectedItems[0].SubItems[2].Text);
            
            conexao = new Conexao();
            conexao.conectar();
            conexao.command.CommandText = "select * from Mensagem where idSolicitacao=@idSolicitacao order by dataHoraMensagem";
            conexao.command.Parameters.Add("@idSolicitacao", SqlDbType.Int).Value = idSolicitacao;
            conexao.command.ExecuteNonQuery();
            conexao.fechaConexao();

            atualizarMensagens();
        }

        private void lstEmAtendimento_DoubleClick(object sender, EventArgs e)
        {
            nomeUsuario = lstEmAtendimento.SelectedItems[0].SubItems[0].Text;
            idUsuario = Convert.ToInt32(lstEmAtendimento.SelectedItems[0].SubItems[1].Text);
            idSolicitacao = Convert.ToInt32(lstEmAtendimento.SelectedItems[0].SubItems[2].Text);

            horaAtual = DateTime.Now;
            horaAtualSql = horaAtual.ToString("yyyy-MM-dd HH:mm:ss.fff");

            if (DialogResult.Yes == MessageBox.Show("Este chat gerou chamado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) 
            {
                MessageBox.Show("Você poderá visualizar esta conversa na aba de 'Chamados'.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao = new Conexao();
                conexao.conectar();

                conexao.command.CommandText = "update Solicitacao set dataHoraTerminoSol = getdate(),emAberto = 1 where idUsuario=@idUsuario and idSolicitacao=@idSolicitacao";
                conexao.command.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                conexao.command.Parameters.Add("@idSolicitacao", SqlDbType.Int).Value = idSolicitacao;
                conexao.command.Parameters.Add("@dataHoraTerminoSol", SqlDbType.DateTime).Value = horaAtualSql;

            }
            else
            {
                MessageBox.Show("Chat finalizado sem nenhuma pendência.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao = new Conexao();
                conexao.conectar();
                conexao.command.CommandText = "update Solicitacao set dataHoraTerminoSol = getdate(),emAberto = 0 where idUsuario=@idUsuario and idSolicitacao=@idSolicitacao";
                conexao.command.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                conexao.command.Parameters.Add("@idSolicitacao", SqlDbType.Int).Value = idSolicitacao;
                conexao.command.Parameters.Add("@dataHoraTerminoSol", SqlDbType.DateTime).Value = horaAtualSql;

            }

            conexao.command.ExecuteNonQuery();
            conexao.fechaConexao();

            foreach (ListViewItem eachItem in lstEmAtendimento.SelectedItems)
            {
                lstEmAtendimento.Items.Remove(eachItem);
            }

            nomeUsuario = "";
            idUsuario = 0;
            idSolicitacao = 0;
            txtRecebe.Clear();

        }

        private void FrmChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }
        
    }
}
