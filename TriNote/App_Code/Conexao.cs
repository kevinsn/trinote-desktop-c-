using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;

public class Conexao
{
    public SqlConnection conexao;
    public SqlCommand command;
    public SqlDataReader reader;
    public String sql;
    string strConexao = "Server=localhost;DataBase=TriNoteTeste;trusted_connection=true";
    //string strConexao = "Server=trinoteserver-1.database.windows.net;DataBase=TriNoteTeste;user id=tnazureuser;password=5NTb3gkp";
    //string strConexao = "Server=localhost;DataBase=TriNoteTeste;user id=sa;password=etesp";
    //string strConexao = "Server=localhost;DataBase=TriNoteTeste;user id=sa;password=teste@123";

    public Conexao()
	{
		
	}

    public void conectar()
    {
        conexao = new SqlConnection(strConexao);
        conexao.Open();
        command = new SqlCommand();
        command.Connection = conexao;

    }

    public void ler()
    {        
        conexao = new SqlConnection(strConexao);
        conexao.Open();
        command = new SqlCommand(sql, conexao);
        reader = command.ExecuteReader();
    }

    public void fechaConexao()
    {
        conexao.Close();
        conexao = null;
        command = null;

    }
    
}
