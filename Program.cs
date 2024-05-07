using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_IMCArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[] alt = new double[5];
            double[] peso = new double[5];
            double[] imc = new double[5];
            double count = 0;

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Digite o seu nome: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite a sua altura: ");
                alt[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o seu peso: ");
                peso[i] = double.Parse(Console.ReadLine());
                imc[i] = peso[i] / (alt[i] * alt[i]);
            }
            
            for(int j = 0; j <= 4; j++) 
            {
                Console.WriteLine("Nome: " + nome[j]);
                Console.WriteLine("IMC: " + imc[j]);
                if (imc[j] <= 18.5)

                    Console.WriteLine("Abaixo do peso.");

                else if (imc[j] >= 18.6 && imc[j] <= 24.9)

                    Console.WriteLine("Peso ideal.");

                else if (imc[j] >= 25 && imc[j] <= 29.9)

                { Console.WriteLine("Levemente acima do peso."); count++; }

                else if (imc[j] >= 30 && imc[j] <= 34.9)

                { Console.WriteLine("Obesidade grau I."); count++; }

                else if (imc[j] >= 35 && imc[j] <= 39.9)

                { Console.WriteLine("Obesidade grau II."); count++; }

                else

                { Console.WriteLine("Obesidade grau III."); count++; }
                
                Console.WriteLine(count + "de 5 estão acima do peso");
            }
            Console.ReadKey();
        }
    }
}
