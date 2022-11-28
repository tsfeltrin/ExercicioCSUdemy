using System.Globalization;

namespace Construtores_Encapsulamento_Sobrecarga_EXERCICIO
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo{ get; private set; }

        public ContaBancaria(int numero, string tiular) // construtores
        {
            Numero = numero;
            Titular = tiular;
        }
        public ContaBancaria(int numero, string titular, double depositoInicial) : this (numero, titular) // construtores
        {
            Deposito(depositoInicial); // quando for executado alguma ação no método abaixo Deposito, automaticamente engloba aquiesta mudança.
        }

        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }
        public void Saque (double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.00;
        }
        public override string ToString()
        {
            return "Conta " 
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
