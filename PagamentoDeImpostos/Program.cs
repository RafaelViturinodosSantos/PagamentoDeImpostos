using System;
using System.Globalization;
using System.Collections.Generic;

namespace PagamentoDeImpostos
{
    class Program
    {
        static void Main(string[] args)
        {
            try {

                List<Dados> d = new List<Dados>();
                int income;
                double helth;
                Console.WriteLine("Enter the number of tax payers ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Tax payer #{0} data", i);
                    Console.Write("Individual or company (i/c)? ");
                    string ic = Console.ReadLine();
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    income = int.Parse(Console.ReadLine());
                    if (ic == "i" || ic == "I" || ic == "Individual")
                    {
                        Console.Write("Helth Expendutures: ");
                        helth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        d.Add(new PessoaFisica(name, income, helth));
                    }
                    else if (ic == "c" || ic == "C" || ic == "Company")
                    {
                        Console.Write("Number of employees: ");
                        int employee = int.Parse(Console.ReadLine());
                        d.Add(new PessoaJuridica(employee, name, income));

                    }
                    else
                    {
                        Console.WriteLine("Valor informado Inválido");
                    }

                }
                Console.WriteLine("Taxes Paid");
                foreach(Dados dados in d)
                {
                    Console.WriteLine(dados.Name + ": $ " + dados.GetDados().ToString("F2", CultureInfo.InvariantCulture));
                }
     
            }

            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine("Valor informado Inválido" + ie.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Informações Inválidas" + e.Message);
            }
            Console.ReadLine();

        }
      
    }
}
