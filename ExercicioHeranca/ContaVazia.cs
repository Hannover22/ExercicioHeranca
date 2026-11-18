using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHeranca
{
    public class ContaVazia : ContaBancaria
    {
        public ContaVazia(string n, string t, decimal s) : base(n, t, s)
        {
            this.Numero = "0";
            this.Tipo = "Vazio";
            this.Saldo = 0;
        }

        public override string ToString()
        {
            return "Espaço para receber conta";
        }
    }
}
