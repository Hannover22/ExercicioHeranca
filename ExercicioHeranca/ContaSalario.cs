using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHeranca
{
    public class ContaSalario : ContaBancaria
    {
        public decimal Saldo { get; set; }

        public override string Sacar(decimal quantia)
        {
            if(quantia > Saldo)
            {
                return "Operação cancelada, saldo insuficiente";
            }
            Saldo -= quantia;
            return "Saque realizado com sucesso.";
        }

        public ContaSalario(string n, string t, decimal s) : base(n, t, s)
        {
            this.Numero = n;
            this.Tipo = t;
            this.Saldo = 0;
        }
        public override string ToString()
        {
            return "Conta salario numero: " + this.Numero;
        }
    }
}
