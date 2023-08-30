// Usando operadores lógicos

// Programa que checa usuário (admin) e senha (1234) para garantir acesso ao sistema ou retornar uma mensagem de erro.

using System;

namespace AprendendoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o usuário:");
            string usuario = Console.ReadLine();

            Console.WriteLine("Digite a senha:");
            string senha = Console.ReadLine();

            if (usuario == "admin" && senha == "1234")
            {
                Console.WriteLine("Acesso permitido.");
            }
            else
            {
                Console.WriteLine("Acesso negado.");
            }
        }
    }
}

// Refatorando o código acima para usar operadores lógicos em loop.

using System;

namespace AprendendoCSharp
{
    public class ProgramaRefatorado
    {
        public static void Main()
        {
            string username, password;
            int maxTentativas = 3;
            int tentativas = 0;

            Console.WriteLine("Checando credenciais de acesso:");
            Console.WriteLine("Insira os dados de acesso (padrão é admin e senha 1234)");
            Console.WriteLine("-----------------------------------------");

            do
            {
                Console.Write("Insira o usuário: ");
                username = Console.ReadLine();

                Console.Write("Insira a senha: ");
                password = Console.ReadLine();

                if (username != "admin" || password != "1234")
                {
                    tentativas++;
                    Console.WriteLine("Credenciais incorretas. Tente novamente.");
                }
                else
                {
                    Console.WriteLine("Acesso concedido!");
                    break; // Sai do loop quando as credenciais estiverem corretas
                }

            } while (tentativas < maxTentativas);

            if (tentativas == maxTentativas)
            {
                Console.WriteLine("\nTentativas de acesso excedidas. Usuário bloqueado!\n");
            }
        }
    }
}

