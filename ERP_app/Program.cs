/* using System;
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
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

class Program
{
    static List<Product> inventory = new List<Product>();

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(new MainForm());
    }

    static void AddProduct(string name, int quantity)
    {
        inventory.Add(new Product { Name = name, Quantity = quantity });
    }

    static void RecordMovement(string name, string movementType, int quantity)
    {
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
                    MessageBox.Show("Quantidade insuficiente em estoque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tipo de movimentação inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    static void DisplayInventory()
    {
        string inventoryText = "\nInventário Atual:\n";

        foreach (var product in inventory)
        {
            inventoryText += $"{product.Name}: {product.Quantity} unidades\n";
        }

        MessageBox.Show(inventoryText, "Inventário", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    static void DisplayAnalytics()
    {
        int totalQuantity = inventory.Sum(p => p.Quantity);
        MessageBox.Show($"Total de Unidades em Estoque: {totalQuantity}", "Análise", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

class Product
{
    public string Name { get; set; }
    public int Quantity { get; set; }
}

class MainForm : Form
{
    public MainForm()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        // Configuração de controles, adicione eventos, etc.

        Button addProductButton = new Button();
        addProductButton.Text = "Adicionar Produto";
        addProductButton.Click += AddProductButton_Click;

        Button recordMovementButton = new Button();
        recordMovementButton.Text = "Registrar Movimentação";
        recordMovementButton.Click += RecordMovementButton_Click;

        Button displayInventoryButton = new Button();
        displayInventoryButton.Text = "Exibir Inventário";
        displayInventoryButton.Click += DisplayInventoryButton_Click;

        Button displayAnalyticsButton = new Button();
        displayAnalyticsButton.Text = "Exibir Análises";
        displayAnalyticsButton.Click += DisplayAnalyticsButton_Click;

        // Adicione os controles ao formulário
        Controls.Add(addProductButton);
        Controls.Add(recordMovementButton);
        Controls.Add(displayInventoryButton);
        Controls.Add(displayAnalyticsButton);

        // Configure o layout, posições, tamanhos, etc.
    }

    private void AddProductButton_Click(object sender, EventArgs e)
    {
        // Lógica para adicionar produto aqui, por exemplo:
        string name = Microsoft.VisualBasic.Interaction.InputBox("Nome do Produto:", "Adicionar Produto", "");
        int quantity = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Quantidade Inicial:", "Adicionar Produto", "0"));

        Program.AddProduct(name, quantity);
    }

    private void RecordMovementButton_Click(object sender, EventArgs e)
    {
        // Lógica para registrar movimentação aqui, por exemplo:
        string name = Microsoft.VisualBasic.Interaction.InputBox("Nome do Produto:", "Registrar Movimentação", "");
        string movementType = Microsoft.VisualBasic.Interaction.InputBox("Tipo de Movimentação (entrada/saída):", "Registrar Movimentação", "").ToLower();
        int quantity = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Quantidade:", "Registrar Movimentação", "0"));

        Program.RecordMovement(name, movementType, quantity);
    }

    private void DisplayInventoryButton_Click(object sender, EventArgs e)
    {
        Program.DisplayInventory();
    }

    private void DisplayAnalyticsButton_Click(object sender, EventArgs e)
    {
        Program.DisplayAnalytics();
    }
}
