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
    public partial class FrmMenuSuporte : Form
    {
        int idFuncionario;
        Conexao conexao = new Conexao();
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        public FrmMenuSuporte(int id)
        {
            InitializeComponent();
            idFuncionario = id;
        }
        
        private void FrmMenuSuporte_Load(object sender, EventArgs e)
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

            // Anotações
            conexao = new Conexao();
            conexao.conectar();
            conexao.command.CommandText = "select count(*) from Anotacao";
            conexao.command.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();
            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            lblRAnotacoes.Text = dataSet.Tables[0].Rows[0][0].ToString();

            // Solicitações
            conexao = new Conexao();
            conexao.conectar();
            conexao.command.CommandText = "select count(*) from Solicitacao";
            conexao.command.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();
            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            lblRSolicitacoes.Text = dataSet.Tables[0].Rows[0][0].ToString();

        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            FrmChat frmChat;
            frmChat = new FrmChat(idFuncionario, 1);
            frmChat.Show();
        }
        
        private void btnChamados_Click(object sender, EventArgs e)
        {
            FrmChat frmChat;
            frmChat = new FrmChat(idFuncionario, 2);            
            frmChat.Show();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            FrmChat frmChat;
            frmChat = new FrmChat(idFuncionario, 3);
            frmChat.Show();            
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            // FrmLogin frmLogin = new FrmLogin();
            // frmLogin.Show();
            // this.Close();
            Application.Exit();
        }
    }
}
