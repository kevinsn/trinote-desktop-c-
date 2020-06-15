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

namespace TriNote
{
    public partial class FrmMenuAdmin : Form
    {
        int idAdmin;

        Conexao conexao = new Conexao();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();

        public FrmMenuAdmin(int id)
        {
            idAdmin = id;
            InitializeComponent();
        }
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            FrmChat frmChat = new FrmChat(idAdmin, 3);
            frmChat.Show();
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            FrmValida frmValida = new FrmValida(idAdmin, 2);
            frmValida.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro(idAdmin, 4);
            frmCadastro.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmLista frmLista = new FrmLista(idAdmin);
            frmLista.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
            //Application.Exit();
        }

        private void FrmMenuAdmin_Load(object sender, EventArgs e)
        {
            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();

            conexao.conectar();
            conexao.command.CommandText = "select count (*) from Usuario";
            conexao.command.ExecuteNonQuery();

            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            lblRUsuarios.Text = dataSet.Tables[0].Rows[0][0].ToString();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();

            conexao.conectar();
            conexao.command.CommandText = "select count(*) from Anotacao";
            conexao.command.ExecuteNonQuery();

            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            lblRAnotacoes.Text = dataSet.Tables[0].Rows[0][0].ToString();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();

            conexao.conectar();
            conexao.command.CommandText = "select count(*) from Solicitacao";
            conexao.command.ExecuteNonQuery();

            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            lblRSolicitacoes.Text = dataSet.Tables[0].Rows[0][0].ToString();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();

            conexao.conectar();
            conexao.command.CommandText = "select count (*) from Anunciante";
            conexao.command.ExecuteNonQuery();

            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            lblRAnunciantes.Text = dataSet.Tables[0].Rows[0][0].ToString();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();

            conexao.conectar();
            conexao.command.CommandText = "select count (*) from Anuncio";
            conexao.command.ExecuteNonQuery();

            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);


            lblRAnuncios.Text = dataSet.Tables[0].Rows[0][0].ToString();

            conexao.fechaConexao();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();

            conexao.conectar();
            conexao.command.CommandText = "select count (*) from Funcionario";
            conexao.command.ExecuteNonQuery();

            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            lblRFuncionarios.Text = dataSet.Tables[0].Rows[0][0].ToString();

        }
    }
}
