// String methods em C#
// Vamos aprender a usar alguns métodos de string em C#.

using System;

namespace AprendendoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo 01 - ToUpper() e ToLower()
            // O método ToUpper() converte todos os caracteres de uma string para maiúsculas.
            // O método ToLower() converte todos os caracteres de uma string para minúsculas.

            string nome = "João";
            string sobrenome = "Silva";

            Console.WriteLine(nome.ToUpper()); // JOÃO
            Console.WriteLine(sobrenome.ToLower()); // silva

            // Exemplo 02 - Trim()
            // O método Trim() remove os espaços em branco do início e do final de uma string.

            string nomeEspacoso = "   João Silva   ";

            Console.WriteLine(nomeEspacoso.Trim()); // João Silva

            // Exemplo 03 - Substring()
            // O método Substring() retorna uma substring (parte) de uma string.

            string nomeCompleto = "João Silva";
            string nomeReduzido = nomeCompleto.Substring(0, 4); // João

            Console.WriteLine(nomeReduzido);

            // Exemplo 04 - Replace()
            // O método Replace() substitui um caractere por outro em uma string.

            string nomeComErro = "João Sylva";
            string nomeCorrigido = nomeComErro.Replace("y", "i"); // João Silva

            // Exemplo 05 - Length
            // O método Length retorna o tamanho de uma string.

            string nomeGrande = "João Silva";
            int tamanho = nomeGrande.Length; // 10

            Console.WriteLine(tamanho);

            // Exemplo 06 - IndexOf()
            // O método IndexOf() retorna a posição de um caractere em uma string.

            string nomeCompleto2 = "João Silva";
            int posicao = nomeCompleto2.IndexOf("S"); // 5

            Console.WriteLine(posicao);

            // Exemplo 07 - Contains()
            // O método Contains() verifica se uma string contém outra string.

            string nomeCompleto3 = "João Silvani";
            bool contem = nomeCompleto3.Contains("Silva"); // true

            Console.WriteLine(contem);

            // Exemplo 08 - StartsWith()
            // O método StartsWith() verifica se uma string começa com outra string.

            string nomeCompleto4 = "João Silva";
            bool comecaCom = nomeCompleto4.StartsWith("João"); // true

            Console.WriteLine(comecaCom);
            // Exemplo 09 - EndsWith()
            // O método EndsWith() verifica se uma string termina com outra string.

            string nomeCompleto5 = "João Silva";
            bool terminaCom = nomeCompleto5.EndsWith("Silva"); // true

            Console.WriteLine(terminaCom);

        }
    }
}

// Confira uma tabela com outros exemplos de manipulação de strings em C#:

// Método	Descrição
// ToUpper()	Converte todos os caracteres de uma string para maiúsculas.
// ToLower()	Converte todos os caracteres de uma string para minúsculas.
// Trim()	Remove os espaços em branco do início e do final de uma string.
// Substring()	Retorna uma substring (parte) de uma string.
// Replace()	Substitui um caractere por outro em uma string.
// Length	Retorna o tamanho de uma string.
// IndexOf()	Retorna a posição de um caractere em uma string.
// Contains()	Verifica se uma string contém outra string.
// StartsWith()	Verifica se uma string começa com outra string.
// EndsWith()	Verifica se uma string termina com outra string.
// Split()	Separa uma string em substrings usando o caractere especificado.
// Join()	Junta uma ou mais strings usando o caractere especificado.
// Format()	Formata uma string usando argumentos.
// IsNullOrEmpty()	Verifica se uma string é nula ou vazia.
// IsNullOrWhiteSpace()	Verifica se uma string é nula, vazia ou consiste apenas em espaços em branco.
// Concat()	Junta duas strings.
// Compare()	Compara duas strings e retorna um inteiro que indica se a primeira string é menor, igual ou maior que a segunda string.
// CompareTo()	Compara duas strings e retorna um inteiro que indica se a primeira string é menor, igual ou maior que a segunda string.
// Equals()	Verifica se duas strings são iguais.
// ToCharArray()	Converte uma string em um array de caracteres.

// Exercícios
// 1) Crie um programa que peça ao usuário para digitar uma palavra e exiba quantos caracteres tem essa palavra.

// 2) Crie um programa que peça ao usuário para digitar uma palavra e exiba quantas vogais tem essa palavra.
// 3) Crie um programa que peça ao usuário para digitar uma palavra e exiba se essa palavra começa com vogal ou consoante.
// 4) Crie um programa que peça ao usuário para digitar uma palavra e exiba se essa palavra termina com vogal ou consoante.
// 5) Crie um programa que peça ao usuário para digitar uma palavra e exiba se essa palavra é um palíndromo ou não.




















// Respostas
// 1) Crie um programa que peça ao usuário para digitar uma palavra e exiba quantos caracteres tem essa palavra.

using System;

namespace AprendendoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();

            Console.WriteLine($"A palavra {palavra} tem {palavra.Length} caracteres.");
        }
    }
}

// 2) Crie um programa que peça ao usuário para digitar uma palavra e exiba quantas vogais tem essa palavra.

using System;

namespace AprendendoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();

            int quantidadeDeVogais = 0;

            foreach (char letra in palavra)
            {
                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    quantidadeDeVogais++;
                }
            }

            Console.WriteLine($"A palavra {palavra} tem {quantidadeDeVogais} vogais.");
        }
    }
}

// 3) Crie um programa que peça ao usuário para digitar uma palavra e exiba se essa palavra começa com vogal ou consoante.

using System;

namespace AprendendoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();

            if (palavra.StartsWith("a") || palavra.StartsWith("e") || palavra.StartsWith("i") || palavra.StartsWith("o") || palavra.StartsWith("u"))
            {
                Console.WriteLine($"A palavra {palavra} começa com vogal.");
            }
            else
            {
                Console.WriteLine($"A palavra {palavra} começa com consoante.");
            }
        }
    }
}

// 4) Crie um programa que peça ao usuário para digitar uma palavra e exiba se essa palavra termina com vogal ou consoante.

using System;

namespace AprendendoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();

            if (palavra.EndsWith("a") || palavra.EndsWith("e") || palavra.EndsWith("i") || palavra.EndsWith("o") || palavra.EndsWith("u"))
            {
                Console.WriteLine($"A palavra {palavra} termina com vogal.");
            }
            else
            {
                Console.WriteLine($"A palavra {palavra} termina com consoante.");
            }
        }
    }
}

// 5) Crie um programa que peça ao usuário para digitar uma palavra e exiba se essa palavra é um palíndromo ou não.

using System;

namespace AprendendoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra:");
            string palavra = "RADAR"

            string palavraInvertida = "RADAR";

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                palavraInvertida += palavra[i];
            }

            if (palavra == palavraInvertida)
            {
                Console.WriteLine($"A palavra {palavra} é um palíndromo.");
            }
            else
            {
                Console.WriteLine($"A palavra {palavra} não é um palíndromo.");
            }
        }
    }
}




