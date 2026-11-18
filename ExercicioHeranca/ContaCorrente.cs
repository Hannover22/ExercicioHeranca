using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ExercicioHeranca
{
    public class ContaCorrente : ContaBancaria
    {
        public decimal Limite;

        public ContaCorrente(string n, string t, decimal s) : base(n, t, s)
        {
            this.Numero = n;
            this.Tipo = t;
            this.Saldo = 0;
        }
        public void SetLimite()
        {
            if(Saldo < 0)
            {
                Limite = 0;
            }
            else
            {
                Limite = Saldo * 3;
            }
        }


        public void Depositar(decimal s)
        {
            this.Saldo += s;
            SetLimite();
        }
        public override string Sacar(decimal valor)
        {
            if (valor > this.Saldo + this.Limite)
            {
                return "Saque impedido por exceder o limite da conta.";
            }
            else
            {
                this.Saldo = Saldo - valor;
                SetLimite();
                return "Saque realizado com sucesso";
            }
        }

        public override string ToString()
        {
            return "Conta corrente numero: " + this.Numero;
        }
    }
}
