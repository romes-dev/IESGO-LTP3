// DataTypes em C#

/* 

São os tipos de dados que podemos usar em C#. Confira exemplos a seguir:

* string - armazena texto, como "Hello". Os valores de string são colocados entre aspas duplas
* int - armazena números inteiros positivos ou negativos sem casas decimais, como 123 ou -123
* double - armazena números com casas decimais, como 19.99 ou -19.99
* char - armazena caracteres únicos, como 'a' ou 'B'. Os valores de char são colocados entre aspas simples
* bool - armazena valores verdadeiros ou falsos, como true ou false


+------------+---------+---------------------------------------+--------------------------+
|  Datatype  | Tamanho |            Descrição                   |          Exemplo         |
+------------+---------+---------------------------------------+--------------------------+
|   int      | 4 bytes |  Representa números inteiros           |        42, -123          |
|------------|---------|---------------------------------------|--------------------------|
|  float     | 4 bytes |  Representa números de ponto flutuante |     3.14, -0.001         |
|------------|---------|---------------------------------------|--------------------------|
|  double    | 8 bytes |  Representa números de ponto flutuante |  3.14159265359, -0.0001  |
|------------|---------|---------------------------------------|--------------------------|
|   char     | 2 bytes |  Representa um caractere Unicode       |         'A', '5'          |
|------------|---------|---------------------------------------|--------------------------|
|  string    | variável|  Representa uma sequência de caracteres|  "Hello", "C# Programming"|
|------------|---------|---------------------------------------|--------------------------|
|  bool      | 1 byte  |  Representa um valor booleano (verdadeiro|  true, false             |
|            |         |  ou falso)                            |                          |
+------------+---------+---------------------------------------+--------------------------+

Nota: a string armaneza 2 bytes por caractere. 

Em C#, as strings são armazenadas como uma sequência de caracteres Unicode. Unicode é um sistema de codificação de caracteres que visa representar a maioria dos caracteres de escrita usados em todo o mundo, independentemente do idioma ou do script. Para acomodar a ampla gama de caracteres, símbolos e caracteres especiais em diferentes idiomas e escritas, o Unicode utiliza codificações que podem exigir mais de 1 byte por caractere.

Os sistemas Unicode mais comuns usados em C# são UTF-16 (Unicode Transformation Format-16) e UTF-8 (Unicode Transformation Format-8). UTF-16 é a codificação padrão para strings em C#, e ele armazena cada caractere em 2 bytes (16 bits).

A razão para usar 2 bytes por caractere em UTF-16 é que isso permite representar uma ampla variedade de caracteres e símbolos, incluindo caracteres em idiomas com escritas complexas, como chinês, japonês, árabe e muitos outros.

Embora UTF-16 use 2 bytes por caractere na maioria dos casos, é importante notar que alguns caracteres especiais e emojis são representados por pares de caracteres de 2 bytes cada (um par de substituição) em UTF-16, resultando em um total de 4 bytes por caractere. Isso é chamado de "par de substituição" e é usado para caracteres que estão fora do plano básico multilíngue do Unicode.

Por outro lado, UTF-8 é uma codificação de caracteres que varia de 1 a 4 bytes por caractere, dependendo do caractere. UTF-8 é mais eficiente em termos de espaço de armazenamento para texto em inglês e outros idiomas que usam predominantemente caracteres de um byte, mas pode exigir mais bytes para caracteres em scripts mais complexos.

Em resumo, as strings em C# armazenam 2 bytes por caractere porque UTF-16 é a codificação de caracteres padrão, que permite representar um amplo conjunto de caracteres em vários idiomas. UTF-8 é outra codificação de caracteres comum que varia de 1 a 4 bytes por caractere, dependendo do caractere.

*/

// Exemplo de uso de Datatypes:

using System;

using System.Text; // Importa o namespace System.Text para trabalhar com codificação UTF-8

class Program
{
    static void Main()
    {
        // Configura a codificação UTF-8 para a saída do console
        Console.OutputEncoding = Encoding.UTF8;

        // Tipos numéricos
        int numeroInteiro = 42;
        double numeroPontoFlutuante = 3.14;
        decimal numeroDecimal = 123.456m;

        // Tipo caractere
        char caractere = 'Á'; // Á é um caractere acentuado

        // Tipo string
        string texto = "Olá, mundo!"; // Contém caracteres acentuados

        // Tipo booleano
        bool booleanoVerdadeiro = true;
        bool booleanoFalso = false;

        // Tipo data e hora
        DateTime dataHoraAtual = DateTime.Now;

        // Exibindo os valores das variáveis
        Console.WriteLine($"Número inteiro: {numeroInteiro}");
        Console.WriteLine($"Número de ponto flutuante: {numeroPontoFlutuante}");
        Console.WriteLine($"Número decimal: {numeroDecimal}");
        Console.WriteLine($"Caractere: {caractere}");
        Console.WriteLine($"Texto: {texto}");
        Console.WriteLine($"Booleano verdadeiro: {booleanoVerdadeiro}");
        Console.WriteLine($"Booleano falso: {booleanoFalso}");
        Console.WriteLine($"Data e hora atual: {dataHoraAtual}");
        Console.WriteLine{$"Console pode entregar um texto: {texto} \n ou pode ser escrita com caractereses \"especiais\". \n E também podem ser escritas \n em uma nova linha..}

        // Espera o usuário pressionar Enter para sair
        Console.ReadLine();

// Conversão de DataTypes

/*

Em C#, você pode converter um tipo de dados em outro tipo de dados. Isso é chamado de conversão de tipo de dados.
Existem dois tipos de conversão de tipo de dados em C#:
@ implícita - conversão automática de um tipo de dados para outro tipo de dados compatível
@ explícita - conversão manual de um tipo de dados para outro tipo de dados compatível



+----------------+---------------------------+------------------------------------+
|   Conversão   |      Descrição            |          Exemplo                   |
+----------------+---------------------------+------------------------------------+
|   Implícita   | Conversão automática      | int x = 42; double y = x;         |
|               | de tipos compatíveis      |                                   |
|----------------|---------------------------|------------------------------------|
|   Explícita   | Conversão manual com      | double x = 3.14; int y = (int)x;  |
|               | possível perda de dados  |                                   |
|----------------|---------------------------|------------------------------------|
|   Parse()      | Converte uma string em    | string str = "123"; int x =       |
|               | um valor numérico         | int.Parse(str);                   |
|----------------|---------------------------|------------------------------------|
|   TryParse()   | Converte uma string em    | string str = "abc"; int x;        |
|               | um valor numérico, com    | if (int.TryParse(str, out x))     |
|               | tratamento de erro        | {                                 |
|               |                           |     // Conversão bem-sucedida   |
|               |                           |     // x contém o valor         |
|               |                           | }                                 |
|----------------|---------------------------|------------------------------------|
|   Convert.ToX  | Converte um valor em um   | double x = 3.14; int y =          |
|               | tipo específico, onde X é  | Convert.ToInt32(x);               |
|               | o tipo desejado           |                                   |
|----------------|---------------------------|------------------------------------|
|   (Tipo)valor  | Conversão direta de       | double x = 3.14; int y = (int)x;  |
|               | tipo, conhecida como       |                                   |
|               | "cast"                    |                                   |
|----------------|---------------------------|------------------------------------|
|   ToString()   | Converte um valor em uma  | int x = 42; string str = x.       |
|               | representação de string   | ToString();                       |
+----------------+---------------------------+------------------------------------+


A conversão do tipo Convert.ToX é mais segura do que a conversão direta de tipo (Tipo)valor, porque ela não gera uma exceção se a conversão falhar. Em vez disso, ela retorna um valor padrão para o tipo de dados, como 0 para int ou 0.0 para double. Veja uma tabela que explica os valores padrão para cada tipo de dados:

+-----------------+-------------------------------------+
|   Método        |          Descrição                   |
+-----------------+-------------------------------------+
|   Convert.ToBoolean(value)  | Converte um valor em um tipo booleano.        |
|-----------------|-------------------------------------|
|   Convert.ToByte(value)      | Converte um valor em um byte (8 bits sem sinal). |
|-----------------|-------------------------------------|
|   Convert.ToChar(value)      | Converte um valor em um caractere Unicode.      |
|-----------------|-------------------------------------|
|   Convert.ToDecimal(value)   | Converte um valor em um decimal (128 bits).     |
|-----------------|-------------------------------------|
|   Convert.ToDouble(value)    | Converte um valor em um número de ponto flutuante de precisão dupla. |
|-----------------|-------------------------------------|
|   Convert.ToInt16(value)     | Converte um valor em um inteiro de 16 bits (Int16). |
|-----------------|-------------------------------------|
|   Convert.ToInt32(value)     | Converte um valor em um inteiro de 32 bits (Int32). |
|-----------------|-------------------------------------|
|   Convert.ToInt64(value)     | Converte um valor em um inteiro de 64 bits (Int64). |
|-----------------|-------------------------------------|
|   Convert.ToSingle(value)    | Converte um valor em um número de ponto flutuante de precisão simples. |
+-----------------+-------------------------------------+


*/

// Exemplo de conversão de DataTypes:


        // Exemplo 1: Conversão de int para double
        int valorInteiro = 42;
        double valorDouble = (double)valorInteiro;
        Console.WriteLine($"Exemplo 1: int para double - Valor double: {valorDouble}");

        // Exemplo 2: Conversão de double para int (com possível perda de dados)
        double valorDouble2 = 3.14;
        int valorInteiro2 = (int)valorDouble2;
        Console.WriteLine($"Exemplo 2: double para int - Valor int: {valorInteiro2}");

        // Exemplo 3: Conversão de string para int usando int.Parse()
        string valorString = "123";
        int valorConvertido = int.Parse(valorString);
        Console.WriteLine($"Exemplo 3: string para int - Valor int: {valorConvertido}");

        // Exemplo 4: Conversão de bool para int
        bool valorBooleano = true;
        int valorInteiro3 = Convert.ToInt32(valorBooleano);
        Console.WriteLine($"Exemplo 4: bool para int - Valor int: {valorInteiro3}");

        // Exemplo 5: Conversão de char para string
        char caracterevar = 'A';
        string caractereString = caracterevar.ToString();
        Console.WriteLine($"Exemplo 5: char para string - Valor string: '{caractereString}'");
    }
}

// Operadores


/*

Operadores Mateáticos

+----------------+---------------------------+------------------------------------+
|   Operador     |      Descrição            |          Exemplo                   |
+----------------+---------------------------+------------------------------------+
|   +            | Adição                    | int x = 10 + 5;                    |
|----------------|---------------------------|------------------------------------|
|   -            | Subtração                 | int x = 10 - 5;                    |
|----------------|---------------------------|------------------------------------|
|   *            | Multiplicação             | int x = 10 * 5;                    |
|----------------|---------------------------|------------------------------------|
|   /            | Divisão                   | int x = 10 / 5;                    |
|----------------|---------------------------|------------------------------------|
|   %            | Módulo                    | int x = 10 % 5;                    |
|----------------|---------------------------|------------------------------------|
|   ++           | Incremento                | int x = 5; x++;                    |
|----------------|---------------------------|------------------------------------|
|   --           | Decremento                | int x = 5; x--;                    |
+----------------+---------------------------+------------------------------------+

Operadores de Atribuição

+----------------+---------------------------+------------------------------------+
|   Operador     |      Descrição            |          Exemplo                   |
+----------------+---------------------------+------------------------------------+
|   =            | Atribuição                | int x = 10;                        |
|----------------|---------------------------|------------------------------------|
|   +=           | Adição                    | int x = 10; x += 5;                |
|----------------|---------------------------|------------------------------------|
|   -=           | Subtração                 | int x = 10; x -= 5;                |
|----------------|---------------------------|------------------------------------|
|   *=           | Multiplicação             | int x = 10; x *= 5;                |
|----------------|---------------------------|------------------------------------|
|   /=           | Divisão                   | int x = 10; x /= 5;                |
|----------------|---------------------------|------------------------------------|
|   %=           | Módulo                    | int x = 10; x %= 5;                |
|----------------|---------------------------|------------------------------------|
|   &=           | E lógico                  | int x = 10; x &= 5;                |
|----------------|---------------------------|------------------------------------|
|   |=           | OU lógico                 | int x = 10; x |= 5;                |
|----------------|---------------------------|------------------------------------|
|   ^=           | OU exclusivo lógico       | int x = 10; x ^= 5;                |
|----------------|---------------------------|------------------------------------|
|   >>=          | Deslocamento à direita    | int x = 10; x >>= 5;               |
|----------------|---------------------------|------------------------------------|
|   <<=          | Deslocamento à esquerda   | int x = 10; x <<= 5;               |
+----------------+---------------------------+------------------------------------+

Operadores de Comparação

+----------------+---------------------------+------------------------------------+
|   Operador     |      Descrição            |          Exemplo                   |
+----------------+---------------------------+------------------------------------+
|   ==           | Igual a                   | int x = 5; x == 5                 |
|----------------|---------------------------|------------------------------------|
|   !=           | Diferente de              | int x = 5; x != 5                 |
|----------------|---------------------------|------------------------------------|
|   >            | Maior que                 | int x = 5; x > 5                  |
|----------------|---------------------------|------------------------------------|
|   <            | Menor que                 | int x = 5; x < 5                  |
|----------------|---------------------------|------------------------------------|
|   >=           | Maior ou igual a          | int x = 5; x >= 5                 |
|----------------|---------------------------|------------------------------------|
|   <=           | Menor ou igual a          | int x = 5; x <= 5                 |
+----------------+---------------------------+------------------------------------+

Operadores Lógicos

+----------------+---------------------------+------------------------------------+
|   Operador     |      Descrição            |          Exemplo                   |
+----------------+---------------------------+------------------------------------+
|   &&           | E lógico                  | int x = 5; x > 3 && x < 10        |
|----------------|---------------------------|------------------------------------|
|   ||           | OU lógico                 | int x = 5; x > 3 || x < 4         |
|----------------|---------------------------|------------------------------------|
|   !            | NÃO lógico                | int x = 5; !(x > 3 && x < 10)     |
+----------------+---------------------------+------------------------------------+

Operadores Bitwise

+----------------+---------------------------+------------------------------------+
|   Operador     |      Descrição            |          Exemplo                   |
+----------------+---------------------------+------------------------------------+
|   &            | E                         | int x = 5; x & 3                  |
|----------------|---------------------------|------------------------------------|
|   |            | OU                        | int x = 5; x | 3                  |
|----------------|---------------------------|------------------------------------|
|   ^            | OU exclusivo              | int x = 5; x ^ 3                  |
|----------------|---------------------------|------------------------------------|
|   ~            | Complemento de um         | int x = 5; ~x                     |
|----------------|---------------------------|------------------------------------|
|   <<           | Deslocamento à esquerda   | int x = 5; x << 3                 |
|----------------|---------------------------|------------------------------------|
|   >>           | Deslocamento à direita    | int x = 5; x >> 3                 |
+----------------+---------------------------+------------------------------------+


*/



