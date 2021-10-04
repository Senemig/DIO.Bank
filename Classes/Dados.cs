using System.Collections.Generic;
using System;

namespace DIO.Bank
{
    public static class Dados
    {
        private static List<Conta> ListaContas;

        static Dados()
        {
            ListaContas = new List<Conta>();
        }

        public static void CriarConta()
        {
            Console.WriteLine("Qual o tipo de conta? (1 - Pessoa Física / 2 - Pessoa Jurídica)");
            Console.Write(">");
            int tipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o nome do titular da conta?");
            Console.Write(">");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o saldo inicial da conta?");
            Console.Write(">");
            double saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o crédito da conta?");
            Console.Write(">");
            double credito = double.Parse(Console.ReadLine());

            Conta conta = new Conta(nome, saldo, credito, (TipoConta)tipoConta);
            ListaContas.Add(conta);
            Console.WriteLine("Conta Criada!");
        }

        public static void ListarContas()
        {
            if (ListaContas.Count > 0)
            {
                for (int i = 0; i < ListaContas.Count; i++)
                {
                    Console.Write($"#{i} ");
                    ListaContas[i].Extrato();
                }
            }
            else
            {
                Console.WriteLine("Nenhuma conta cadastrada!");
            }
        }

        public static void Transferir(int origem, int destino, double valor)
        {
            if (origem < ListaContas.Count && destino < ListaContas.Count)
                ListaContas[origem].Transferencia(valor, ListaContas[destino]);
            else
                Console.WriteLine("Conta não existente!");
        }

        public static void Saque(int conta, double valor)
        {
            ListaContas[conta].Sacar(valor);
        }

        public static void Deposito(int conta, double valor)
        {
            ListaContas[conta].Depositar(valor);
        }

        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            Console.Write(">");
            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}