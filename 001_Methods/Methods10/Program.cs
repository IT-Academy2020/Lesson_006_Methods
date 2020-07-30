using System;

// Методи з вихідними параметрами (out).

namespace Methods
{
    class Program
    {
        static int Method(out int a)
        {
            // Вихідні параметри повинні бути змінені в тілі методу, інакше нічого не вийде.
            a = 2;
            return a * 2;
        }

        static void Main()
        {
            int operand;

            // out - дозволяє передавати в метод непроініціалізовані змінні.
            
            int result = Method(out operand);

            Console.WriteLine("{0}; {1};", operand, result);

            // Delay.
            Console.ReadKey();
        }
    }
}
