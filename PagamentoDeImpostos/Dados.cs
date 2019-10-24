using System;
using System.Collections.Generic;
using System.Text;

namespace PagamentoDeImpostos
{
   abstract class Dados
    {
        public string Name { get; protected set; }
        public int  Income { get; protected set; }

        protected Dados(string name, int income)
        {
            Name = name;
            Income = income;
        }

        public abstract double GetDados();
    }
}
