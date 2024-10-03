/*
A IESGO tem diferentes veículos (Carros, Motos e Caminhões)
cada um tem suas características/comportamentos
Todos têm: Marca, Modelo, Velocidade Máxima.
Cada um tem um comportamento para consumo de combustível

Classe Base Veiculo:
	•	Atributos:
    	•   Marca (string)
    	•	Modelo (string)
    	•	VelocidadeMaxima (double)
	•	Métodos:
    	•	CalcularConsumo(): Deve ser um método virtual que será sobrescrito nas classes derivadas.
    	•	ExibirInformacoes(): Método que exibe as informações do veículo e o consumo de combustível (esse método será sobrescrito nas classes derivadas).
    	
    •	Classe Carro:
    	•	Sobrescrever o método CalcularConsumo(), onde o consumo é calculado como: 12 km/l de combustível.
    	•	Sobrescrever o método ExibirInformacoes().
	•	Classe Moto:
    	•	Sobrescrever o método CalcularConsumo(), onde o consumo é calculado como: 40 km/l.
    	•	Sobrescrever o método ExibirInformacoes().
	•	Classe Caminhao:
    	•	Sobrescrever o método CalcularConsumo(), onde o consumo é calculado como: 8 km/l.
    	•	Sobrescrever o método ExibirInformacoes().
    	
 Encapsulamento: Os atributos da classe base devem ser privados e acessados via propriedades públicas.
 Polimorfismo: o método Main(), crie uma lista de veículos (Carros, Motos e Caminhões) e exiba as informações de cada um, utilizando o polimorfismo para chamar o método ExibirInformacoes() da maneira apropriada.
*/


using System;
using System.Collections.Generic;

// Classe base Veiculo com encapsulamento e métodos virtuais
public class Veiculo
{
    private string marca;
    private string modelo;
    private double velocidadeMaxima;

    // Propriedades
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public double VelocidadeMaxima
    {
        get { return velocidadeMaxima; }
        set { velocidadeMaxima = value; }
    }

    // Método virtual para calcular o consumo
    public virtual double CalcularConsumo()
    {
        return 0; // Base genérica
    }

    // Método virtual para exibir informações
    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Velocidade Máxima: {VelocidadeMaxima} km/h");
    }
}

// Classe derivada Carro
public class Carro : Veiculo
{
    public override double CalcularConsumo()
    {
        return 12; // Consumo de 12 km/l para carros
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Consumo: {CalcularConsumo()} km/l");
    }
}

// Classe derivada Moto
public class Moto : Veiculo
{
    public override double CalcularConsumo()
    {
        return 20; // Consumo de 20 km/l para motos
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Consumo: {CalcularConsumo()} km/l");
    }
}

// Classe derivada Caminhao
public class Caminhao : Veiculo
{
    public override double CalcularConsumo()
    {
        return 8; // Consumo de 8 km/l para caminhões
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Consumo: {CalcularConsumo()} km/l");
    }
}

// Classe principal
class Program
{
    static void Main(string[] args)
    {
        // Lista de veículos
        List<Veiculo> veiculos = new List<Veiculo>();

        // Adicionar veículos à lista
        veiculos.Add(new Carro { Marca = "Toyota", Modelo = "Corolla", VelocidadeMaxima = 180 });
        veiculos.Add(new Moto { Marca = "Honda", Modelo = "CBR", VelocidadeMaxima = 220 });
        veiculos.Add(new Caminhao { Marca = "Volvo", Modelo = "FH", VelocidadeMaxima = 120 });

        // Exibir informações dos veículos
        Console.WriteLine("Informações dos Veículos:");
        foreach (var veiculo in veiculos)
        {
            veiculo.ExibirInformacoes();
            Console.WriteLine(); // Pular linha
        }

        // Aguardar o usuário
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
