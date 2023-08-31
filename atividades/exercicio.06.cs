// NOVA FORMA DE PAGAMENTO INSTANTANEO - PÍQUIS

// O Banco Píquis está desenvolvendo uma nova forma de pagamento instantâneo, o Píquis.
// Você foi convidado(a) para refatorar esse código e aprimorar alguns detalhes:

// 1. O sistema deve permitir que o usuário realize quantas transferências quiser, até que ele decida sair.
// 2. O sistema deve verificar se o beneficiário existe antes de realizar a transferência.
// 3. O sistema deve verificar se o valor da transferência é maior que zero.
// 4. O sistema deve verificar se o saldo do usuário é suficiente para realizar a transferência.
// 5. O sistema deve exibir uma mensagem de sucesso após a transferência.
// 6. Certifique-se de validar se o nome da conta inserido é válido (ou seja, "joao" ou "maria") e exiba uma mensagem de erro se o nome da conta não for reconhecido.
// 7. O sistema deve exibir o saldo do usuário quando o usuário escolher a opção de exibir o saldo.
// 8. O sistema deve exibir uma mensagem de erro se o usuário tentar realizar uma transferência para ele mesmo.
// 9. O sistema deve exibir uma mensagem de erro se o usuário tentar realizar uma transferência para uma conta inexistente.
// 10. O sistema deve exibir uma mensagem de erro se o usuário tentar realizar uma transferência com um valor maior que o saldo disponível.
using System;

class Program
{
    static void Main()
    {
        // Inicialização de contas com saldo
        double contaJoao = 1000.0;
        double contaMaria = 1500.0;

        while (true)
        {
            Console.WriteLine("Bem-vindo ao sistema de transferência PIX!");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Realizar uma transferência");
            Console.WriteLine("2. Sair");

            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                Console.WriteLine("Digite o nome do beneficiário:");
                string beneficiario = Console.ReadLine();

                // Verificar se o beneficiário existe (João ou Maria)
                if (beneficiario.ToLower() == "joao" || beneficiario.ToLower() == "maria")
                {
                    Console.WriteLine("Digite o valor da transferência:");
                    double valorTransferencia = Convert.ToDouble(Console.ReadLine());

                    if (valorTransferencia <= 0)
                    {
                        Console.WriteLine("O valor da transferência deve ser maior que zero.");
                    }
                    else if (valorTransferencia > contaJoao)
                    {
                        Console.WriteLine("Saldo insuficiente para realizar a transferência.");
                    }
                    else
                    {
                        // Realizar a transferência
                        if (beneficiario.ToLower() == "joao")
                        {
                            contaJoao -= valorTransferencia;
                            contaMaria += valorTransferencia;
                        }
                        else
                        {
                            contaMaria -= valorTransferencia;
                            contaJoao += valorTransferencia;
                        }

                        Console.WriteLine($"Transferência de {valorTransferencia:C2} para {beneficiario} realizada com sucesso!");
                        Console.WriteLine($"Saldo atual de João: {contaJoao:C2}");
                        Console.WriteLine($"Saldo atual de Maria: {contaMaria:C2}");
                    }
                }
                else
                {
                    Console.WriteLine("Beneficiário não encontrado. Verifique o nome e tente novamente.");
                }
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Obrigado por usar o sistema de transferência PIX. Adeus!");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, escolha 1 para realizar uma transferência ou 2 para sair.");
            }
        }
    }
}
