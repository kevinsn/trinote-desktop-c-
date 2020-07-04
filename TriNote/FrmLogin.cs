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
    public partial class FrmLogin : Form
    {
        Criptografia criptografia = new Criptografia();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Focused && txtLogin.Text != "" && txtSenha.Text == "")
            {
                txtSenha.Focus();
            } 
            else
            {

                if ((txtLogin.Text != "") && (txtSenha.Text != ""))
                {
                    String loginFuncionario = txtLogin.Text;
                    String senhaFuncionario = txtSenha.Text;
                    int permissaoFuncionario;
                    int id;
                    Conexao conexao;
                    SqlDataAdapter dataAdapter;
                    DataSet dataSet;

                    conexao = new Conexao();
                    conexao.conectar();
                    criptografia = new Criptografia();
                    //MessageBox.Show(senhaFuncionario);
                    senhaFuncionario = criptografia.criptografar(senhaFuncionario);
                    //MessageBox.Show(senhaFuncionario);
                    conexao.command.CommandType = CommandType.StoredProcedure;
                    conexao.command.CommandText = "usp_checarLoginFunc";
                    //conexao.command.CommandText = "select * from Funcionario where loginFuncionario=@Login and senhaFuncionario=@Senha";
                    conexao.command.Parameters.Add("@loginFuncionario", SqlDbType.VarChar).Value = loginFuncionario;
                    conexao.command.Parameters.Add("@senhaFuncionario", SqlDbType.VarChar).Value = senhaFuncionario;
                    conexao.command.ExecuteNonQuery();

                    dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = conexao.command;
                    dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    conexao.fechaConexao();

                    if (dataSet.Tables[0].Rows.Count == 0)
                    {
                        permissaoFuncionario = 0;
                        id = 0;
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                        MessageBox.Show("Login e/ou senha incorretos.");
                    }
                    else
                    {
                        permissaoFuncionario = Convert.ToInt32(dataSet.Tables[0].Rows[0]["permissaoFuncionario"]);
                        id = Convert.ToInt32(dataSet.Tables[0].Rows[0]["idFuncionario"]);

                        if (id > 0 && permissaoFuncionario == 1)
                        {
                            FrmMenuSuporte frmMenuSuporte = new FrmMenuSuporte(id);
                            frmMenuSuporte.Show();
                        }
                        else if (id > 0 && permissaoFuncionario == 2)
                        {
                            FrmMenuMarketing frmMenuMarketing = new FrmMenuMarketing(id);
                            frmMenuMarketing.Show();
                        }
                        else if (id > 0 && permissaoFuncionario == 3)
                        {
                            FrmMenuGerencia frmMenuGerencia = new FrmMenuGerencia(id);
                            frmMenuGerencia.Show();
                        }
                        else if (id > 0 && permissaoFuncionario == 4)
                        {
                            FrmMenuAdmin frmMenuAdmin = new FrmMenuAdmin(id);
                            frmMenuAdmin.Show();
                        }

                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Preenchimento de todos os campos exigidos.");
                }
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
