using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHeranca
{
    public class ContaCorrente : ContaBancaria
    {
        public decimal Limite { get; set; }
        public decimal Saldo { get; set; }

        public ContaCorrente(string n, string t, decimal s) : base(n, t, s)
        {
            this.Numero = n;
            this.Tipo = t;
            this.Saldo = 0;
        }
        public void SetLimite()
        {
            this.Limite = this.Saldo * 3;
            if(this.Saldo < 0)
            {
                this.Limite = 0;
            }
        }


        public void Depositar(decimal s)
        {
            this.Saldo = s;
        }
        public override string Sacar(decimal valor)
        {
            decimal maximo = Saldo * 4;
            if(valor > maximo)
            {
                return "Saque impedido por exceder o limite da conta.";
            }
            Saldo -= valor;
            return "Saque realizado com sucesso";
        }

        public override string ToString()
        {
            return "Conta corrente numero: " + this.Numero;
        }
    }
}
