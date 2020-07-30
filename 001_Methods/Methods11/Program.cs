using System;
using System.Text;

// Метод з вихідними параметрами.

namespace Methods
{
    class Program
    {
        // Вихідні параметри повинні бути змінені в тілі метода, інакше нічого не вийде.
        
        static int Method(out int a)
        {
            // Закоментувати!
            a = 1;

            return 2;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int operand;

            // out - дозволяє передавати в метод непроініціалізовані змінні.

            int result = Method(out operand);

            Console.WriteLine("{0}; {1};", operand, result);

            // Delay.
            Console.ReadKey();
        }
    }
}
