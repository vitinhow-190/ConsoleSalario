using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSalario
{
    internal class Program
    {
        static void Main(string[] args)
        { double salario0 = 0;
            Console.WriteLine("Informe sua situação de emprego (assalariado, omissionado, orista)");
            string sit = Console.ReadLine();

            switch (sit) 
            {
                case "assalariado":

                    Console.WriteLine("Informe o valor do seu salário bruto: ");
                    double sal = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor dos descontos: ");
                    double desc = double.Parse(Console.ReadLine());
                    
                    salario0 = sal - desc;

                    Console.WriteLine("Seu salário liquido é: " +  salario0);

                break;

                case "omissionado":

                    Console.WriteLine("Informe a quantidade de peças vendidas: ");
                    double sala = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor da comissão por peça vendida: ");
                    double comi = double.Parse(Console.ReadLine());
                    
                    salario0 = sala * comi;

                    Console.WriteLine("Seu salário é: " + salario0);

                break;

                case "orista":

                    Console.WriteLine("Informe o valor da hora trabalhada: ");
                    double vlhr = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
                    double qtdhrs= double.Parse(Console.ReadLine());

                    salario0 = vlhr * qtdhrs;

                    Console.WriteLine("Seu salário liquido é: " + salario0);

                break;
            }

            if (salario0 < 2000) 
            {

                salario0 = salario0 * 0.075;

                Console.WriteLine("O valor do seu IR é de: " + salario0);           
            }
            else if (salario0 > 2000 && salario0 < 4000) 
            {

                salario0 = salario0 * 0.12;

                Console.WriteLine("O valor do seu IR é de: " + salario0);           
            }
            else if (salario0 > 4000)
            {
                salario0 = salario0 * 0.15;

                Console.WriteLine("O valor do seu IR é de: " + salario0);                       
            }







            Console.ReadKey();
        }
    }
}
