using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHeranca
{
    public abstract class ContaBancaria
    {
        public string Numero { get; set; }
        public decimal Saldo { get; set; }
        public string Tipo { get; set; }

        public ContaBancaria(string n, string t, decimal s)
        {
            this.Numero = n;
            this.Tipo = t;
            this.Saldo = 0;
        }

        public void Depositar(decimal quantia)
        {
            this.Saldo += quantia;
        }

        public virtual string Sacar(decimal quantia)
        {
            this.Saldo -= quantia;
            return "Saque realizado com sucesso.";
        }

        public void Transferencia(decimal quantia)
        {
            this.Saldo -= quantia;
        }
        public void Pagar(decimal quantia)
        {
            this.Saldo -= quantia;
        }
        public override string ToString()
        {
            return "Espaço para receber conta";
        }
    }
}
