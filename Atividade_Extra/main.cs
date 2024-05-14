using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Product> inventory = new List<Product>();

    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Sistema de Gerenciamento de Inventário!");

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Adicionar Produto");
            Console.WriteLine("2. Registrar Movimentação");
            Console.WriteLine("3. Exibir Inventário");
            Console.WriteLine("4. Exibir Análises");
            Console.WriteLine("5. Sair");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    RecordMovement();
                    break;
                case "3":
                    DisplayInventory();
                    break;
                case "4":
                    DisplayAnalytics();
                    break;
                case "5":
                    Console.WriteLine("Até logo!");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void AddProduct()
    {
        Console.Write("Nome do Produto: ");
        string name = Console.ReadLine();

        Console.Write("Quantidade Inicial: ");
        int quantity = int.Parse(Console.ReadLine());

        inventory.Add(new Product { Name = name, Quantity = quantity });

        Console.WriteLine($"{name} adicionado ao estoque com {quantity} unidades.");
    }

    static void RecordMovement()
    {
        Console.Write("Nome do Produto: ");
        string name = Console.ReadLine();

        Console.Write("Tipo de Movimentação (entrada/saída): ");
        string movementType = Console.ReadLine().ToLower();

        Console.Write("Quantidade: ");
        int quantity = int.Parse(Console.ReadLine());

        Product product = inventory.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (product != null)
        {
            if (movementType == "entrada")
            {
                product.Quantity += quantity;
            }
            else if (movementType == "saída")
            {
                if (product.Quantity >= quantity)
                {
                    product.Quantity -= quantity;
                }
                else
                {
                    Console.WriteLine("Quantidade insuficiente em estoque.");
                }
            }
            else
            {
                Console.WriteLine("Tipo de movimentação inválido.");
            }
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }

    static void DisplayInventory()
    {
        Console.WriteLine("\nInventário Atual:");

        foreach (var product in inventory)
        {
            Console.WriteLine($"{product.Name}: {product.Quantity} unidades");
        }
    }

    static void DisplayAnalytics()
    {
        int totalQuantity = inventory.Sum(p => p.Quantity);
        Console.WriteLine($"\nTotal de Unidades em Estoque: {totalQuantity}");
    }
}

class Product
{
    public string Name { get; set; }
    public int Quantity { get; set; }
}
