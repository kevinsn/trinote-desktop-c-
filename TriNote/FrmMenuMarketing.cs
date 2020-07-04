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
    public partial class FrmMenuMarketing : Form
    {
        int idFuncionario;

        Conexao conexao;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        
        public FrmMenuMarketing(int id)
        {
            idFuncionario = id;
            InitializeComponent();
        }

        private void FrmMenuMarketing_Load(object sender, EventArgs e)
        {
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

            // Anúncios
            conexao = new Conexao();
            conexao.conectar();
            conexao.command.CommandText = "select count (*) from Anuncio";
            conexao.command.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();
            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            lblRAnuncios.Text = dataSet.Tables[0].Rows[0][0].ToString();

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            FrmValida frmValida = new FrmValida(idFuncionario, 1);
            frmValida.Show();
        }

        private void btnAnuncios_Click(object sender, EventArgs e)
        {
            FrmValida frmValida = new FrmValida(idFuncionario, 3);
            frmValida.Show();
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
