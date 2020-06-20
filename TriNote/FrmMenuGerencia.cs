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
    public partial class FrmMenuGerencia : Form
    {
        int idGerencia;

        Conexao conexao;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        public FrmMenuGerencia(int id)
        {
            idGerencia = id;
            InitializeComponent();
        }

        private void FrmMenuGerencia_Load(object sender, EventArgs e)
        {
            // Usuários
            conexao = new Conexao();
            conexao.conectar();
            conexao.command.CommandText = "select count (*) from Usuario";
            conexao.command.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();
            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            lblRUsuarios.Text = dataSet.Tables[0].Rows[0][0].ToString();

            // Anunciantes
            conexao = new Conexao();
            conexao.conectar();
            conexao.command.CommandText = "select count (*) from Anunciante";
            conexao.command.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();
            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            lblRAnunciantes.Text = dataSet.Tables[0].Rows[0][0].ToString();
            
            // Funcionários
            conexao = new Conexao();
            conexao.conectar();
            conexao.command.CommandText = "select count (*) from Funcionario";
            conexao.command.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();
            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            lblRFuncionarios.Text = dataSet.Tables[0].Rows[0][0].ToString();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            FrmChat frmChat = new FrmChat(idGerencia, 3);
            frmChat.Show();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            FrmValida frmValida = new FrmValida(idGerencia, 2);
            frmValida.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro(idGerencia, 3);
            frmCadastro.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
            //Application.Exit();
        }

    }
}
