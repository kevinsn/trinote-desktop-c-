using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriNote
{
    public class Criptografia
    {
        string senhaCripto = "";
        int tamanhoSenha = 0;
        const string valor = " ";
        const string valor2 = "~";
        byte[] valorByte = Encoding.ASCII.GetBytes(valor); // pegando os valores do primeiro caracter
        byte[] valorByte2 = Encoding.ASCII.GetBytes(valor2); // do último caracter válido
        string charSenha = "";
        string novoCharSenha = "";
        byte[] codigoCharSenha;
        bool caracterValido = true;
        bool senhaValida = true;

        public Criptografia()
        {

        }

        // Método que criptografa a senha e deve ser chamado
        public string criptografar(string senha)
        {
            int tamanhoSenha = senha.Length;
            senhaValida = checarCaracter(senha);
            if (senhaValida == true)
            {
                for (int i = 0; i < tamanhoSenha; i++)
                {
                    charSenha = senha.Substring(i, 1);
                    codigoCharSenha = Encoding.ASCII.GetBytes(charSenha);
                    int a = valorByte[0] + valorByte2[0] - codigoCharSenha[0];
                    novoCharSenha = System.Text.ASCIIEncoding.Default.GetString(BitConverter.GetBytes(a));
                    senhaCripto += charSenha.Replace(charSenha, novoCharSenha);                    
                }
            }
            else
            {
                senhaCripto = "";
            }

            return senhaCripto;
        }

        // Checando se o caracter é válido, range do 0-126 da tabelas ASCII,
        // se não for ele retorna falso
        private bool checarCaracter(string senha)
        {
            for (int i = 0; i < tamanhoSenha; i++)
            {
                charSenha = senha.Substring(i, 1);
                codigoCharSenha = Encoding.ASCII.GetBytes(charSenha);
                bool result = Regex.IsMatch(charSenha, @".*[^\u0000-\u007F].*");

                if (result == true)
                {
                    caracterValido = false;
                }
            }

            if (caracterValido == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
