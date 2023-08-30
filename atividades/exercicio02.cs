// Exercício em C# 
/*

Escreva um código em C# que Solicite ao usuário que escreva seu nome e depois solicite o seu sobrenome. Ao final, imprima no console o nome e o sobrenome juntos em uma mesma linha.

*/

using System;

namespace atividades
{
    class exercicio04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Seu nome completo é: " + nome + " " + sobrenome);
        }
    }
}