using System;

namespace DIO.Bank
{
    public class Conta
    {
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private TipoConta TipoConta { get; set; }

        public Conta(string nome, double saldo, double credito, TipoConta tipoConta)
        {
            Nome = nome;
            Saldo = saldo;
            Credito = credito;
            this.TipoConta = tipoConta;
        }

        public bool Sacar(double valorSaque)
        {
            if(Saldo - valorSaque < Credito * (-1))
            {
                Console.WriteLine("\nSaldo insuficiente na conta!");
                return false;
            }

            Saldo -= valorSaque;
            Console.WriteLine($"\nSaldo atual na conta de {Nome} é: {Saldo.ToString("N2")}");
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;
            Console.WriteLine($"\nSaldo atual na conta de {Nome} é: {Saldo.ToString("N2")}");
        }

        public void Transferencia(double valorTransferencia, Conta contaDestino)
        {
            if(Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
            else
            {
                Console.WriteLine("\nSaldo insuficiente na conta!");
            }
        }

        public void Extrato()
        {
            Console.WriteLine("Tipo de conta: " + TipoConta
             + "| Nome do titular: " + Nome
             + "| Saldo: R$" + Saldo.ToString("N2")
             + "| Credito: R$" + Credito.ToString("N2") + "\n");
        }
    }
}