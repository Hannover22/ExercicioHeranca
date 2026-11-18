using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExercicioHeranca
{
    public class ContaPoupanca : ContaBancaria
    {
        public decimal Saldo { get; set; }

        public ContaPoupanca(string n, string t, decimal s) : base(n, t, s)
        {
            this.Numero = n;
            this.Tipo = t;
            this.Saldo = s;
        }

        public void Depositar(decimal s)
        {
            this.Saldo += s;
        }

        public override string Sacar(decimal quantia)
        {
            if(quantia > Saldo)
            {
                return "Operação cancelada, saldo insuficiente";
            }
            Saldo = Saldo - (quantia + (quantia/20));
            return "Saque realizado com 5% de desconto devido ao modelo da conta.";
        }
        public override string ToString()
        {
            return "Conta poupança numero: " + this.Numero;
        }
    }
}
