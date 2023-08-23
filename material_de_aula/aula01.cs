using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Olá, Mundo!");    
    }
  }
}

/*
Aqui está a explicação do exemplo:

Linha 1: using System significa que podemos usar classes do namespace System.

Linha 2: Uma linha em branco. C# ignora espaços em branco. No entanto, várias linhas em branco tornam o código mais legível.

Linha 3: namespace é usado para organizar seu código e é um contêiner para classes e outros namespaces.

Linha 4: As chaves {} marcam o início e o fim de um bloco de código.

Linha 5: class é um contêiner para dados e métodos, que trazem funcionalidade para o seu programa. Cada linha de código que é executada em C# deve estar dentro de uma classe. No nosso exemplo, nomeamos a classe como "Programa".

Não se preocupe se você não entender como using System, namespace e class funcionam. Apenas pense nisso como algo que (quase) sempre aparece no seu programa, e você aprenderá mais sobre eles em um capítulo posterior.

Linha 7: Outra coisa que sempre aparece em um programa C# é o método Main. Qualquer código dentro das chaves {} dele será executado. Você não precisa entender as palavras-chave antes e depois de Main. Você vai conhecê-las aos poucos enquanto lê este tutorial.

Linha 9: Console é uma classe do namespace System, que possui um método WriteLine() usado para imprimir texto. No nosso exemplo, ele imprimirá "Olá, Mundo!".

Se você omitir a linha using System, você terá que escrever System.Console.WriteLine() para imprimir texto.

Nota: Cada declaração em C# termina com um ponto e vírgula (;).

Nota: C# é sensível a maiúsculas e minúsculas: "MinhaClasse" e "minhaclasse" têm significados diferentes.

Nota: Ao contrário do Java, o nome do arquivo C# não precisa corresponder ao nome da classe, mas geralmente eles coincidem (para uma melhor organização). Ao salvar o arquivo, use um nome apropriado e adicione ".cs" ao final do nome do arquivo. Para executar o exemplo acima no seu computador, certifique-se de que o C# esteja instalado corretamente
*/