using System;

namespace Banco
{
    public class CuentaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public CuentaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(double monto)
        {
            Saldo += monto;
            Console.WriteLine($"Depósito realizado exitosamente. Saldo actual: {Saldo}");
        }

        public void Retirar(double monto)
        {
            if (monto > Saldo)
                Console.WriteLine("Fondos Insuficientes.");
            else
            {
                Saldo -= monto;
                Console.WriteLine($"Retiro exitoso. Saldo actual: {Saldo}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria("Elva", 2000);
            cuenta.Depositar(300);
            cuenta.Retirar(130);
            cuenta.Retirar(50);
        }
    }
}