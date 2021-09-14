using System;
using System.Globalization;

namespace Exercicios.Estrutura.Properties
{
    class ContaBancaria
    {
        private string _nome;
        public double Saldo { get; private set; }
        public int Conta { get; private set; }

        public ContaBancaria() {}

        public ContaBancaria(string nome, int conta)
        {
            _nome = nome;
            Conta = conta;
        }

        public ContaBancaria(string nome, double depositoInicial, int conta) : this(nome, conta)
        {
            Deposito(depositoInicial);
        }

        /// <summary> Get e Set que verifica o nome para validação </summary>
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Nome Inválido");
                }
                else
                {
                    _nome = value;
                }
            }
        }

        /// <summary> Acrescenta o depósito ao saldo </summary>
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        /// <summary> Retira o valor de saque da conta </summary>
        public void Saque(double valor)
        {
            Saldo -= valor + 5.00;
        }

        public override string ToString()
        {
            string saldo = Saldo.ToString("F2", CultureInfo.InvariantCulture);

            return "Conta " + Conta + ", Titular: " + _nome + ", Saldo: $ " + saldo;
        }
    }
}