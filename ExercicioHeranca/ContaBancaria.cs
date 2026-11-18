using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            Saldo += quantia;
        }

        public virtual string Sacar(decimal quantia)
        {
            if(quantia <= 0)
            {
                return "Valor inválido";
            }
            else
            {
                if(quantia > this.Saldo)
                {
                    return "Quantia insuficiente";
                }
                else
                {
                    Saldo -= quantia;
                    return "Saque efetuado";
                }
            }
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
