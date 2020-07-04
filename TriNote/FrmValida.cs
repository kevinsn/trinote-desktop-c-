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
using System.IO;

namespace TriNote
{
    public partial class FrmValida : Form
    {
        int idFuncionario;
        int idAnuncio;
        int tipoValida;

        Conexao conexao;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        Timer timer;

        private void FrmValida_Load(object sender, EventArgs e)
        {
            // Anúncios só visualizar
            if (tipoValida == 2) 
            {
                this.Text = "Anúncio";
                lblValidar.Visible = false;
                txtCausa.Enabled = false;
                btnSim.Visible = false;
                btnNao.Visible = false;
            }

            // Anúncios lista de anúncios
            if (tipoValida == 3)
            {
                this.Size = new Size(720, 715);
                this.Text = "Lista de anúncios";
                lblValidar.Visible = false;
                lblTitulo.Visible = false;
                lblDescricao.Visible = false;
                lblCausa.Visible = false;

                picAnuncio.Visible = false;                
                txtDescricao.Visible = false;
                txtCausa.Visible = false;
                btnSim.Visible = false;
                btnNao.Visible = false;
                                
                lstAnuncios.Location = new System.Drawing.Point(12, 12);                
                lstAnuncios.Size = new System.Drawing.Size(680, 652);

                lstAnuncios.Columns[5].Width = 0;
            }

            atualizarListaAnuncios();

            timer = new Timer();
            timer.Interval = (5 * 500);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }

        public FrmValida(int id, int tipoValida)
        {
            InitializeComponent();
            idFuncionario = id;
            this.tipoValida = tipoValida;
            txtDescricao.Focus();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Refresh
            // MessageBox.Show("Estou no timer");
            //if (lstAnuncios.Focused == false)
            //{
            //    atualizarListaAnuncios();
            //}

        }

        private void atualizarListaAnuncios()
        {
            // conexao.sql = "select nomeUsuario,idUsuario from Usuario";
            // conexao.sql = "select (select nomeAnunciante from Anunciante where idAnunciante = Anunciante_idAnunciante) as nomeAnunciante,idAnuncio,valor,validacao,dataTermino,titulo,descricao from anuncio where dataTermino < GETDATE() and validacao is not null";
            
            conexao = new Conexao();
            conexao.sql = "select (select nomeAnunciante from Anunciante where idAnunciante = Anunciante_idAnunciante) as nomeAnunciante,idAnuncio,valor,validacao,dataTermino,(select nomeFuncionario from Funcionario where idFuncionario = funcionarioValidou) as nomeFuncionario,titulo,descricao from anuncio";
            conexao.ler();

            lstAnuncios.Items.Clear();

            while (conexao.reader.Read())
            {
                ListViewItem lv = new ListViewItem(conexao.reader.GetString(0));
                lv.SubItems.Add(conexao.reader.GetInt32(1).ToString());
                lv.SubItems.Add(conexao.reader.GetDecimal(2).ToString());
                if (conexao.reader.GetInt32(3) == 0)
                {
                    lv.SubItems.Add("Não Validado");
                }
                else if (conexao.reader.GetInt32(3) == 1)
                {
                    lv.SubItems.Add("Aceito");
                }
                else if (conexao.reader.GetInt32(3) == 2)
                {
                    lv.SubItems.Add("Recusado");
                }
                
                //lv.SubItems.Add(conexao.reader.GetBoolean(3).ToString());
                lv.SubItems.Add(conexao.reader.GetDateTime(4).ToString());
                if (conexao.reader.IsDBNull(5))
                {
                    lv.SubItems.Add("Nenhum Funcionário");
                }
                else
                {
                    lv.SubItems.Add(conexao.reader.GetString(5).ToString());
                }                
                lstAnuncios.Items.Add(lv);

            }

            conexao.reader.Close();
            conexao.fechaConexao();

            // MessageBox.Show("Estou no atualizar ListaEspera");
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            conexao = new Conexao();
            conexao.conectar();

            // dataAdapter = new SqlDataAdapter();
            // dataSet = new DataSet();

            conexao.command.CommandText = "update Anuncio set validacao = 1,causa=@causa,funcionarioValidou=@funcionarioValidou where idAnuncio=@idAnuncio";
            conexao.command.Parameters.Add("@causa", SqlDbType.VarChar).Value = txtCausa.Text;
            conexao.command.Parameters.Add("@idAnuncio", SqlDbType.Int).Value = idAnuncio;
            conexao.command.Parameters.Add("@funcionarioValidou", SqlDbType.Int).Value = idFuncionario;
            conexao.command.ExecuteNonQuery();
            atualizarListaAnuncios();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            conexao = new Conexao();
            conexao.conectar();

            // dataAdapter = new SqlDataAdapter();
            // dataSet = new DataSet();

            conexao.command.CommandText = "update Anuncio set validacao = 2 where idAnuncio=@idAnuncio";
            conexao.command.Parameters.Add("@idAnuncio", SqlDbType.Int).Value = idAnuncio;
            conexao.command.ExecuteNonQuery();
            atualizarListaAnuncios();
        }

        private void lstAnuncios_DoubleClick(object sender, EventArgs e)
        {
            lblTitulo.Text = "";
            txtDescricao.Text = "";
            txtCausa.Text = "";
            idAnuncio = Convert.ToInt32(lstAnuncios.SelectedItems[0].SubItems[1].Text);

            conexao = new Conexao();
            conexao.conectar();
            conexao.command.CommandText = "select * from Anuncio where idAnuncio=@idAnuncio";
            conexao.command.Parameters.Add("@idAnuncio", SqlDbType.Int).Value = idAnuncio;
            conexao.command.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();
            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            idAnuncio = Convert.ToInt32(dataSet.Tables[0].DefaultView[0].Row["idAnuncio"]);

            conexao = new Conexao();
            conexao.conectar();
            conexao.command.CommandText = "select titulo,descricao,imagem from Anuncio where idAnuncio=@idAnuncio";
            conexao.command.Parameters.Add("@idAnuncio", SqlDbType.Int).Value = idAnuncio;
            conexao.command.ExecuteNonQuery();
            conexao.fechaConexao();

            idAnuncio = Convert.ToInt32(lstAnuncios.SelectedItems[0].SubItems[1].Text);

            lblTitulo.Text += dataSet.Tables[0].DefaultView[0].Row["titulo"].ToString();
            txtDescricao.Text += dataSet.Tables[0].DefaultView[0].Row["descricao"].ToString();
            txtCausa.Text += dataSet.Tables[0].DefaultView[0].Row["causa"].ToString();

            // Comentado para quando não tiver imagem no banco


            Byte[] data = new Byte[0];
            if (dataSet.Tables[0].DefaultView[0].Row["imagem"] != DBNull.Value)
            {
                data = (Byte[])(dataSet.Tables[0].Rows[0]["imagem"]);
                MemoryStream mem = new MemoryStream(data);
                picAnuncio.Image = Image.FromStream(mem);
            }                        

        }

        private void FrmValida_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }
    }
}
