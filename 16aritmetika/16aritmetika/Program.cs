using System;

namespace _16aritmetika
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Chose : +, -, *, or /");
            string choose = Console.ReadLine();

            Console.WriteLine("Въведете първото число:");
            int dec1 = int.Parse(Console.ReadLine());
            string hex1 = dec1.ToString("X");

            Console.WriteLine("Въведете второто число:");
            int dec2 = int.Parse(Console.ReadLine());
            string hex2 = dec2.ToString("X");

            Console.WriteLine(hex1);
            Console.WriteLine(hex2);
            Console.WriteLine();

            double a = Convert.ToInt32(hex1, 16);
            double b = Convert.ToInt32(hex2, 16);
          
            if (choose == "+")
            { 
                double sum = a + b; 
                string sum1 = Convert.ToString(sum);
                int sum2 = Convert.ToInt32(sum1, 16);
                Console.WriteLine("{0} + {1} = {2}", a, b, sum2 );
            }
            else if (choose == "-") 
            { 
                double raz = a - b;
                string raz1 = Convert.ToString(raz);
                double raz2 = Convert.ToInt32(raz1, 16);
                Console.WriteLine("{0} - {1} = {2}", a, b, raz2);
            }
            else if (choose == "*") 
            { 
                double pro = a * b;
                string pro1 = Convert.ToString(pro);
                double pro2 = Convert.ToInt32(pro1, 16);
                Console.WriteLine("{0} * {1} = {2}", a, b, pro2);
            }
            else if (choose == "/") 
            { 
                double chas = a / b;
                string chas1 = Convert.ToString(chas);
                double chas2 = Convert.ToInt32(chas1, 16);
                Console.WriteLine("{0} / {1} = {2}", a, b, chas2);
            }
        }
    }
}
