// Variáveis em C# /////////////////////////////////////////////////////////////////

/* 
##############################################################################################################
##############################################################################################################
###############################@@@@   Variáveis em C#  @@@@###################################################
##############################################################################################################
##############################################################################################################

Em C#, existem diferentes tipos de variáveis (definidas com diferentes palavras-chave), por exemplo:
* int = para números inteiros
* double = para números com ponto flutuante
* char = para caracteres únicos
* string = para texto
* bool = para valores booleanos (verdadeiro ou falso)
* int[] = para vetores de inteiros
* string[] = para vetores de texto
* enum = para enumeradores
* struct = para estruturas
* class = para classes
* float = para números com ponto flutuante de precisão simples
* decimal = para números com ponto flutuante de alta precisão
* object = para objetos
* dynamic = para variáveis dinâmicas
* byte = para números inteiros positivos
* sbyte = para números inteiros
* short = para números inteiros
* ushort = para números inteiros
* uint = para números inteiros
* long = para números inteiros
* ulong = para números inteiros
* char[] = para vetores de caracteres
* bool[] = para vetores de valores booleanos
* float[] = para vetores de números com ponto flutuante de precisão simples
* double[] = para vetores de números com ponto flutuante
* decimal[] = para vetores de números com ponto flutuante de alta precisão
* object[] = para vetores de objetos
* dynamic[] = para vetores de variáveis dinâmicas
* enum[] = para vetores de enumeradores
* struct[] = para vetores de estruturas
* class[] = para vetores de classes

......> Declarando Variáveis em C#

Para criar uma variável, você deve especificar o tipo e atribuir-lhe um valor:
Exemplo:
int minhaIdade = 18;
long meuNumero = 15L;
float meuNumeroDecimal = 5.99F;
double meuNumeroDecimal2 = 5.99D;
decimal meuNumeroDecimal3 = 5.99M;
double meuNumeroCientifico = 5E-8D;
bool meuBooleano = true;
char meuCaractere = 'D';
string meuTexto = "Hello";

*/

// Exemplo de um código em C# que declara três tipos de variáveis coletadas no Console (Nome, idade, altura):

using System;

namespace MeuPrograma


{
    class Program
    {
        static void Main(string[] args)
        {
        string nome = "John";
        int idade = 35;
        double altura = 1.85D;
        Console.WriteLine("Meu nome e " + nome + ", E tenho " + idade + " anos e " + altura + " de altura.");
        }
    }
}


/*

##############################################################################################################
##############################################################################################################
###############################@@@@   Constantes em C#  @@@@##################################################
##############################################################################################################
##############################################################################################################

Constantes são valores fixos que não podem ser alterados durante a execução do programa.
Constantes são declaradas com a palavra-chave const.
Constantes são nomeadas usando letras maiúsculas e sublinhados.

Exemplo:
const double PI = 3.14159;

*/

// Declaração de constantes para dias da semana:

using System;

namespace MeuProgramaDiasdaSemana

{
    class Program
    {
        static void Main(string[] args)
        {
        const string segunda = "Segunda-feira";
        const string terca = "Terca-feira";
        const string quarta = "Quarta-feira";
        const string quinta = "Quinta-feira";
        const string sexta = "Sexta-feira";
        const string sabado = "Sabado";
        const string domingo = "Domingo";
        Console.WriteLine("Os dias da semana sao: " + segunda + ", " + terca + ", " + quarta + ", " + quinta + ", " + sexta + ", " + sabado + " e " + domingo + ".");
        }
    }
}


/* Trabalhando com múltiplas variáveis em C#

Você pode declarar várias variáveis do mesmo tipo em uma linha, separando-as com vírgulas, como este exemplo:

int x = 5, y = 6, z = 50;

Você também pode declarar várias variáveis de um tipo, com um valor comum e separá-las com vírgulas, como este exemplo:

int x = 5, y = 6, z = x + y;

Você pode declarar as variáveis sem atribuir valor, somente o datatyo, como este exemplo:

string nome, sobrenome, nomeCompleto;
int x, y, z;

Você pode atribuir valores a múltiplas variáveis de uma só vez, como este exemplo:

x = y = z = 23;

*/

// Nomeando Variáveis em C# (Indentifiers)

/*
Todas as variávies em C# devem ser identificadas com nomes exclusivos, os chamados `unique names` (Indentifiers).
Os identificadores podem ser nomes curtos como (x e y) ou nomes mais descritivos (idade, soma, volume).
Nota: Recomenda-se o uso de nomes mais descritivos para criar um código mais inteligível.

/// bom exemplo:
int minutosPorHora = 60;

/// mau exemplo:
int m = 60;

As regras de Clean Code para nomear variáveis são:
* Nomes podem conter letras, dígitos e sublinhados
* Nomes devem começar com uma letra ou um sublinhado (underscore)
* Nomes devem começar com uma letra minúscula e não podem conter espaços
* Nomes são `case sensitive` (maiúsculas e minúsculas fazem diferença). Assim, minhaVariavel e minhavariavel são nomes diferentes.
* Cuidado com palavras reservadas (palavras que já tem um significado em C#, como int ou string). Não use palavras reservadas como nomes de variáveis!

*/