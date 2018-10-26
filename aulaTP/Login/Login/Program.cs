using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis para armazenar as senhas
            string senha_usuario, minha_Senha;
            //Solicitando a senha ao usuário
            Console.Write("Digite sua senha: ");
            senha_usuario = Console.ReadLine();
            //Senha de acesso ao sistema
            minha_Senha = "123Matheus";
            //Condição para caso senha esteja correta/incorreta
            if(senha_usuario == minha_Senha)
            {
                Console.WriteLine("Acesso permitido.");
            }
            else
            {
                Console.WriteLine("Você não tem acesso ao sistema.");
            }
            //Manter executando
            Console.ReadLine();
        }
    }
}
