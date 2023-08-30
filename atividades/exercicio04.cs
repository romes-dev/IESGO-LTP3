/* Exercício: Verificação de Elegibilidade para Votação

Descrição:
Crie um programa em C# que determine se um usuário é elegível para votar com base em sua idade e nacionalidade.

Instruções:

Solicite ao usuário que insira sua idade como um número inteiro.
Solicite ao usuário que insira sua nacionalidade como uma string (por exemplo, "brasileiro" ou "estrangeiro").
Use operadores lógicos e aritméticos para verificar se o usuário é elegível para votar nas eleições brasileiras.
Exiba uma mensagem que indique se o usuário é elegível ou não.
Regras de Elegibilidade:

Para votar no Brasil, a idade mínima é de 16 anos.
Apenas cidadãos brasileiros são elegíveis para votar.
Dicas:

Use operadores de comparação como >, <, ==, !=, etc., para comparar valores.
Use operadores lógicos como && (E lógico) e || (OU lógico) para combinar condições.
Use a função Console.ReadLine() para receber entradas do usuário e Convert.ToInt32() para converter a entrada de idade em um número inteiro.
Use a função Console.WriteLine() para exibir mensagens de saída.

*/

using System;

namespace atividades
{
    class exercicio04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua nacionalidade: ");
            string nacionalidade = Console.ReadLine();

            if (idade >= 16 && nacionalidade == "brasileiro")
            {
                Console.WriteLine("Você é elegível para votar!");
            }
            else
            {
                Console.WriteLine("Você não é elegível para votar!");
            }
        }
    }
}