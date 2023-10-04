/* Crie um programa em C# que realize o seguinte:

Solicite ao usuário que insira seu nome completo.
Solicite ao usuário que insira sua idade.
Utilize métodos de string para realizar as seguintes operações:
Exiba o nome completo em maiúsculas.
Exiba o nome completo em minúsculas.
Conte o número de caracteres no nome completo (ignorando espaços em branco).
Converta a idade fornecida pelo usuário em um número inteiro.
Calcule o ano de nascimento do usuário com base na idade fornecida (supondo que o ano atual seja 2023).
Exiba o ano de nascimento calculado e a idade em que o usuário fará 100 anos.
Dicas:

Use os métodos ToUpper(), ToLower(), Length, Trim() e conversões para manipular as strings.
Use a classe Convert para converter a idade fornecida em um número inteiro.
Lembre-se de que o ano de nascimento pode ser calculado subtraindo a idade do ano atual (2023). */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome completo:");
        string nomeCompleto = Console.ReadLine();

        Console.WriteLine("Digite sua idade:");
        string idade = Console.ReadLine();

        Console.WriteLine($"Nome completo em maiúsculas: {nomeCompleto.ToUpper()}");
        Console.WriteLine($"Nome completo em minúsculas: {nomeCompleto.ToLower()}");
        Console.WriteLine($"Número de caracteres no nome completo: {nomeCompleto.Trim().Length}");

        int idadeInteiro = Convert.ToInt32(idade);
        int anoNascimento = 2023 - idadeInteiro;

        Console.WriteLine($"Ano de nascimento: {anoNascimento}");
        Console.WriteLine($"Idade em que fará 100 anos: {100 - idadeInteiro}");
    }
}