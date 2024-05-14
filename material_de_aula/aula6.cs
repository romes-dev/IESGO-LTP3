/* Sistema Básico de Gerenciamento de Livros
Objetivo: Criar um sistema simples para gerenciar uma lista de livros, onde cada livro possui um título, autor e ISBN (Número Padrão Internacional de Livro).

Definição da Classe Livro:

Título
Autor
ISBN
Métodos da Classe Livro:

ExibirDetalhes(): Exibirá os detalhes do livro no console.
Definição da Classe Biblioteca:

Lista de Livros
Métodos da Classe Biblioteca:

AdicionarLivro(Livro livro): Adiciona um novo livro à lista.
ExibirLivros(): Exibe os detalhes de todos os livros na biblioteca. 
Instancie pelo menos 5 livros nessa Biblioteca.

+-----------------------+-------------------------------------------------+
| Operação              | Descrição                                       |
+-----------------------+-------------------------------------------------+
| Add(T item)           | Adiciona um item ao final da lista.             |
+-----------------------+-------------------------------------------------+
| AddRange(IEnumerable) | Adiciona múltiplos itens ao final da lista.     |
+-----------------------+-------------------------------------------------+
| Remove(T item)        | Remove a primeira ocorrência de um item.        |
+-----------------------+-------------------------------------------------+
| RemoveAt(int index)   | Remove o item na posição especificada.          |
+-----------------------+-------------------------------------------------+
| Contains(T item)      | Verifica se a lista contém o item especificado. |
+-----------------------+-------------------------------------------------+
| Sort()                | Ordena a lista usando o comparador padrão.      |
+-----------------------+-------------------------------------------------+
| Clear()               | Remove todos os itens da lista.                 |
+-----------------------+-------------------------------------------------+
| Count                 | Obtém o número de elementos na lista.           |
+-----------------------+-------------------------------------------------+
| Insert(int, T item)   | Insere um item em um índice especificado.       |
+-----------------------+-------------------------------------------------+
| Find(Predicate<T>)    | Encontra o primeiro item que atende ao critério.|
+-----------------------+-------------------------------------------------+





*/

using System;
using System.Collections.Generic;

public class Livro 
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"ISBN: {ISBN}");
    }
}

public class Biblioteca
{
    private List<Livro> livros = new List<Livro>();

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void ExibirLivros()
    {
        foreach(var livro in livros)
        {
            Console.WriteLine("#####################");
            livro.ExibirDetalhes();
            Console.WriteLine("#####################");
        }
    }
}

public class Program
{
    public static void Main()
    {
        var livro01 = new Livro 
        { 
            Titulo = "Harry Potter and the Cursed Child - Parts One and Two (Special Rehearsal Edition)", 
            Autor = "J. K. Rowling", 
            ISBN = "1234-9843"  
        }; // Adicionado ponto e vírgula aqui

        var biblioteca = new Biblioteca();
        biblioteca.AdicionarLivro(livro01);

        biblioteca.ExibirLivros(); // Corrigido para chamar o método no objeto e não na classe.
    }
}











}



