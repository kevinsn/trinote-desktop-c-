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
    public partial class FrmLista : Form
    {
        int idGerencia;
        String nomeFuncionario;
        int idFuncionario;
        String loginFuncionario;
        int tipoPermissao;
        Boolean statusFuncionario;
        string senhaFuncionario;
        Criptografia criptografia = new Criptografia();

        Conexao conexao;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        public FrmLista(int id)
        {
            InitializeComponent();
            idGerencia = id;
        }

        private void FrmLista_Load(object sender, EventArgs e)
        {
            atualizarFuncionarios();
        }

        private void lstFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            conexao = new Conexao();
            conexao.conectar();
            idFuncionario = Convert.ToInt32(lstFuncionarios.SelectedItems[0].SubItems[1].Text);
            conexao.command.CommandText = "select * from Funcionario where idFuncionario=@idFuncionario";
            conexao.command.Parameters.Add("@idFuncionario", SqlDbType.Int).Value = idFuncionario;
            conexao.command.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();
            dataAdapter.SelectCommand = conexao.command;
            dataAdapter.Fill(dataSet);
            conexao.fechaConexao();

            nomeFuncionario = dataSet.Tables[0].Rows[0]["nomeFuncionario"].ToString();
            loginFuncionario = dataSet.Tables[0].Rows[0]["loginFuncionario"].ToString();
            tipoPermissao = Convert.ToInt32(dataSet.Tables[0].Rows[0]["permissaoFuncionario"]);
            statusFuncionario = Convert.ToBoolean(dataSet.Tables[0].Rows[0]["statusfuncionario"]);

            txtNome.Text = nomeFuncionario;
            txtLogin.Text = loginFuncionario;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // dataAdapter = new SqlDataAdapter();
            // dataSet = new DataSet();

            if (rbSuporte.Checked)
            {
                tipoPermissao = 1;
            }

            if (rbMarketing.Checked)
            {
                tipoPermissao = 2;
            }

            if (rbGerencia.Checked)
            {
                tipoPermissao = 3;
            }

            if (rbAdmin.Checked)
            {
                tipoPermissao = 4;
            }

            if (rbAtivo.Checked)
            {
                statusFuncionario = true;
            }

            if (rbInativo.Checked)
            {
                statusFuncionario = false;
            }

            conexao = new Conexao();
            conexao.conectar();
            criptografia = new Criptografia();
            senhaFuncionario = txtSenhaAtual.Text;
            senhaFuncionario = criptografia.criptografar(senhaFuncionario);
            //conexao.command.CommandText = "select * from Funcionario where loginFuncionario=@Login and senhaFuncionario=@Senha";
            conexao.command.CommandText = "select * from Funcionario where loginFuncionario=@Login";
            conexao.command.Parameters.Add("@Login", SqlDbType.VarChar).Value = txtLogin.Text;
            //conexao.command.Parameters.Add("@Senha", SqlDbType.VarChar).Value = senhaFuncionario;
            conexao.command.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = conexao.command;
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            conexao.fechaConexao();

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Erro.");
            }
            else
            {
                if (txtSenha.Text != "" && txtConfirmarSenha.Text != "")
                {
                    if (statusFuncionario == true)
                    {
                        conexao = new Conexao();
                        conexao.conectar();
                        criptografia = new Criptografia();
                        senhaFuncionario = txtSenha.Text;
                        senhaFuncionario = criptografia.criptografar(senhaFuncionario);
                        conexao.command.CommandText = "update Funcionario set nomeFuncionario=@nomeFuncionario, permissaoFuncionario=@permissaoFuncionario ,senhafuncionario=@senhafuncionario,statusfuncionario=1 where idFuncionario=@idFuncionario";
                        conexao.command.Parameters.Add("@nomeFuncionario", SqlDbType.VarChar).Value = txtNome.Text;
                        conexao.command.Parameters.Add("@permissaoFuncionario", SqlDbType.Int).Value = tipoPermissao;
                        //conexao.command.Parameters.Add("@senhafuncionario", SqlDbType.VarChar).Value = senhaFuncionario;
                        conexao.command.Parameters.Add("@idFuncionario", SqlDbType.Int).Value = idFuncionario;
                    }
                    else
                    {
                        conexao = new Conexao();
                        conexao.conectar();
                        criptografia = new Criptografia();
                        senhaFuncionario = txtSenha.Text;
                        senhaFuncionario = criptografia.criptografar(senhaFuncionario);
                        conexao.command.CommandText = "update Funcionario set nomeFuncionario=@nomeFuncionario, permissaoFuncionario=@permissaoFuncionario ,senhafuncionario=@senhafuncionario,statusfuncionario=0 where idFuncionario=@idFuncionario";
                        conexao.command.Parameters.Add("@nomeFuncionario", SqlDbType.VarChar).Value = txtNome.Text;
                        conexao.command.Parameters.Add("@permissaoFuncionario", SqlDbType.Int).Value = tipoPermissao;
                        //conexao.command.Parameters.Add("@senhafuncionario", SqlDbType.VarChar).Value = senhaFuncionario;
                        conexao.command.Parameters.Add("@idFuncionario", SqlDbType.Int).Value = idFuncionario;
                    }

                    conexao.command.ExecuteNonQuery();
                    conexao.fechaConexao();

                    atualizarFuncionarios();

                    MessageBox.Show("Dados e senha atualizados.");
                }
                else
                {
                    if (statusFuncionario == true)
                    {
                        conexao = new Conexao();
                        conexao.conectar();
                        criptografia = new Criptografia();
                        senhaFuncionario = txtSenhaAtual.Text;
                        senhaFuncionario = criptografia.criptografar(senhaFuncionario);
                        conexao.command.CommandText = "update Funcionario set nomeFuncionario=@nomeFuncionario, permissaoFuncionario=@permissaoFuncionario ,senhafuncionario=@senhafuncionario,statusfuncionario=1 where idFuncionario=@idFuncionario";
                        conexao.command.CommandText = "update Funcionario set nomeFuncionario=@nomeFuncionario, permissaoFuncionario=@permissaoFuncionario ,statusfuncionario=1 where idFuncionario=@idFuncionario";
                        conexao.command.Parameters.Add("@nomeFuncionario", SqlDbType.VarChar).Value = txtNome.Text;
                        conexao.command.Parameters.Add("@permissaoFuncionario", SqlDbType.Int).Value = tipoPermissao;
                        //conexao.command.Parameters.Add("@senhafuncionario", SqlDbType.VarChar).Value = senhaFuncionario;
                        conexao.command.Parameters.Add("@idFuncionario", SqlDbType.Int).Value = idFuncionario;
                    }
                    else
                    {
                        conexao = new Conexao();
                        conexao.conectar();
                        criptografia = new Criptografia();
                        senhaFuncionario = txtSenhaAtual.Text;
                        senhaFuncionario = criptografia.criptografar(senhaFuncionario);
                        conexao.command.CommandText = "update Funcionario set nomeFuncionario=@nomeFuncionario, permissaoFuncionario=@permissaoFuncionario ,senhafuncionario=@senhafuncionario,statusfuncionario=0 where idFuncionario=@idFuncionario";
                        conexao.command.CommandText = "update Funcionario set nomeFuncionario=@nomeFuncionario, permissaoFuncionario=@permissaoFuncionario ,statusfuncionario=0 where idFuncionario=@idFuncionario";
                        conexao.command.Parameters.Add("@nomeFuncionario", SqlDbType.VarChar).Value = txtNome.Text;
                        conexao.command.Parameters.Add("@permissaoFuncionario", SqlDbType.Int).Value = tipoPermissao;
                        //conexao.command.Parameters.Add("@senhafuncionario", SqlDbType.VarChar).Value = senhaFuncionario;
                        conexao.command.Parameters.Add("@idFuncionario", SqlDbType.Int).Value = idFuncionario;
                    }

                    conexao.command.ExecuteNonQuery();
                    conexao.fechaConexao();

                    atualizarFuncionarios();

                    MessageBox.Show("Dados atualizados.");

                    txtNome.Clear();
                    txtLogin.Clear();
                    txtSenhaAtual.Clear();
                    txtSenha.Clear();
                    txtConfirmarSenha.Clear();
                    rbSuporte.Checked = false;
                    rbMarketing.Checked = false;
                    rbGerencia.Checked = false;
                    rbAdmin.Checked = false;
                    rbAtivo.Checked = false;
                    rbInativo.Checked = false;
                }

            }

        }

        private void atualizarFuncionarios()
        {
            conexao = new Conexao();
            conexao.sql = "select nomeFuncionario,idFuncionario,loginfuncionario,permissaoFuncionario,statusfuncionario from Funcionario";
            conexao.ler();

            lstFuncionarios.Items.Clear();

            while (conexao.reader.Read())
            {
                ListViewItem lv = new ListViewItem(conexao.reader.GetString(0));
                lv.SubItems.Add(conexao.reader.GetInt32(1).ToString());
                lv.SubItems.Add(conexao.reader.GetString(2));
                if (conexao.reader.GetInt32(3) == 1)
                {
                    lv.SubItems.Add("Suporte");
                }
                if (conexao.reader.GetInt32(3) == 2)
                {
                    lv.SubItems.Add("Marketing");
                }
                if (conexao.reader.GetInt32(3) == 3)
                {
                    lv.SubItems.Add("Gerência");
                }

                if (conexao.reader.GetInt32(3) == 4)
                {
                    lv.SubItems.Add("Administrador");
                }
                //lv.SubItems.Add(conexao.reader.GetInt32(3).ToString());
                if (conexao.reader.GetBoolean(4) == true)
                {
                    lv.SubItems.Add("Sim");
                }
                else
                {
                    lv.SubItems.Add("Não");
                }
                //lv.SubItems.Add(conexao.reader.GetBoolean(3).ToString());
                lstFuncionarios.Items.Add(lv);

            }

            conexao.reader.Close();
            conexao.fechaConexao();
        }

    }
}
