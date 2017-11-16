using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olen allahindluse programm. Sisesta summa:");
            Console.WriteLine();

            string input = Console.ReadLine();
            Console.WriteLine($"Summa: {input}");
            decimal summa = decimal.Parse(input);

            Console.WriteLine();
            Console.WriteLine("Tavaklient");

            if ((summa < 250) && (summa >= 50))
            {
                Console.WriteLine("Allahindlus: 10%");
                decimal summa10 = (summa * 90 / 100);
                Console.WriteLine($"Tasuda: " +summa10);
                Console.ReadLine();
            }

            if ((summa < 350) && (summa >= 250))
            {
                Console.WriteLine("Allahindlus: 20%");
                decimal summa20 = (summa * 80 / 100);
                Console.WriteLine($"Tasuda: " + summa20);
                Console.ReadLine();
            }

            if (summa >= 350)
            {
                Console.WriteLine("Allahindlus: 30%");
                decimal summa30 = (summa * 70 / 100);
                Console.WriteLine($"Tasuda: " + summa30);
                Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Püsiklient");

            if ((summa < 250) && (summa >= 50))
            {
                Console.WriteLine("Allahindlus: 20%");
                decimal summa20 = (summa * 80 / 100);
                Console.WriteLine($"Tasuda: " + summa20);
                Console.ReadLine();
            }

            if ((summa < 350) && (summa >= 250))
            {
                Console.WriteLine("Allahindlus: 30%");
                decimal summa30 = (summa * 70 / 100);
                Console.WriteLine($"Tasuda: " + summa30);
                Console.ReadLine();
            }

            if (summa >= 350)
            {
                Console.WriteLine("Allahindlus: 40%");
                decimal summa40 = (summa * 60 / 100);
                Console.WriteLine($"Tasuda: " + summa40);
                Console.ReadLine();
            }


        }
    }
}
