/*

Exercício: Calculadora de Idade

Descrição:
Crie um programa em C# que peça ao usuário sua data de nascimento e calcule sua idade. Em seguida, exiba a idade em anos.

Instruções:

Solicite ao usuário que insira o ano de nascimento como um número inteiro.
Use a função DateTime.Now.Year para obter o ano atual.
Calcule a idade subtraindo o ano de nascimento do ano atual.
Exiba a idade em anos no console.
Dicas:

Você precisará converter o ano de nascimento (entrada do usuário) em um tipo int para realizar o cálculo.
Use uma variável para armazenar a idade calculada.
Use a função Console.ReadLine() para receber a entrada do usuário e Convert.ToInt32() para converter a entrada em um número inteiro.

*/

using System;

namespace atividades
{
    class exercicio01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano de nascimento: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());
            int anoAtual = DateTime.Now.Year;
            int idade = anoAtual - anoNascimento;
            Console.WriteLine("Sua idade é: " + idade);
        }
    }
}