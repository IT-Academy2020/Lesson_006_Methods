using System;
using System.Text;

namespace Methods
{
    class Program
    {
        static void Add(ref int x, ref int y, int sum)
        {
            sum = x + y;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть 1-e число.");
           
            string operand1 = Console.ReadLine();
            int summand1 = Int32.Parse(operand1);

            Console.WriteLine("Введіть 2-e число.");
            
            string operand2 = Console.ReadLine();
            int summand2 = Int32.Parse(operand2);

            int sum = 0;

            Add(ref summand1, ref summand2, sum);

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum); // Помилка.

            // Delay.
            Console.ReadKey();
        }
    }
}
