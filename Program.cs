using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = Dados.ObterOpcaoUsuario();

            while (opcao.ToUpper() != "X")
            {
                switch (opcao.ToUpper())
                {
                    case "1": //Listar contas
                        Dados.ListarContas();
                        break;

                    case "2": //Criar conta
                        Console.WriteLine("\nCriando uma nova conta!\n");
                        Dados.CriarConta();
                        break;

                    case "3": //Fazer transferência
                        Console.WriteLine("Fazendo transferência!");
                        Console.Write("Insira o número da conta de origem:");
                        int contaOrigem = int.Parse(Console.ReadLine());

                        Console.Write("Insira o número da conta de destino:");
                        int contaDestino = int.Parse(Console.ReadLine());

                        Console.Write("Insira o valor a ser transferido:");
                        double valorTransferencia = int.Parse(Console.ReadLine());

                        Dados.Transferir(contaOrigem, contaDestino, valorTransferencia);
                        break;

                    case "4": //Fazer um saque
                        Console.WriteLine("Fazendo saque!");
                        Console.Write("Insira o número da conta:");
                        int conta = int.Parse(Console.ReadLine());

                        Console.Write("Insira o valor a ser sacado:");
                        double valor = int.Parse(Console.ReadLine());

                        Dados.Saque(conta, valor);
                        break;

                    case "5": //Fazer um saque
                        Console.WriteLine("Fazendo deposito!");
                        Console.Write("Insira o número da conta:");
                        conta = int.Parse(Console.ReadLine());

                        Console.Write("Insira o valor a ser depositado:");
                        valor = int.Parse(Console.ReadLine());

                        Dados.Deposito(conta, valor);
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Comando inválido!");
                        break;
                }

                opcao = Dados.ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por usar nossos serviços!");
        }
    }
}
