using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PagamentoDeImpostos
{
    class PessoaFisica : Dados
    {
        
        public double Helth { get; protected set; }
        public double Rate { get; set; }
        public double Desc { get; set; }

        public PessoaFisica(string name,int income,double helth) :base(name,income) 
        {
            Helth = helth;
        }

        public override double GetDados()
        {
            if(Income < 20000 && Helth > 0.0)
            {
               return (Income * 0.15) - (Helth*0.5);
            }
            else if(Income < 20000 && Helth <= 0)
            {
                return Income * 0.15;
            }
            else if (Income >= 20000 && Helth > 0)
            {
                return (Income * 0.25) - (Helth*0.5);
            }
            else 
            {
                return Income * 0.25;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("TAXES PAID: ");
            sb.Append(Name);
            sb.Append(": $");
            sb.Append(GetDados().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
