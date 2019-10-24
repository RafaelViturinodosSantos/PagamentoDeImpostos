using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PagamentoDeImpostos
{
    class PessoaJuridica : Dados
    {
        public int Employee { get; protected set; }

        public PessoaJuridica(int employee, string name,int income) : base(name,income)
        {
            Employee = employee;
        }
        public override double GetDados()
        {
            if (Employee < 10)
            {
                return Income * 0.16;
            }
            else 
            {
                return Income * 0.14;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("TAXES PIX: ");
            sb.Append(Name);
            sb.Append(": $ ");
            sb.Append(GetDados().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
    

