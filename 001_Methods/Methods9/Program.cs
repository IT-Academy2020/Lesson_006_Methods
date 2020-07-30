using System;

// Методи із змінними параметрами (ref = in / out).

namespace Methods
{
    class Program
    {
        // Якщо в тілі методу виконається зміна значення змінної переданої по посиланню,
        // її значення буде змінено всюди

        static int Method(ref int a)
        {
            int b = a * 2;
            a = 5;
            return b;
        }

        static void Main()
        {
            // Змінна яка передається у метод як ref аргумент, повинна бути оголошена до передачі, інакше помилка.
            int operand = 2;

            int result = Method(ref operand);

            Console.WriteLine("{0}; {1};", operand, result);

            // Delay.
            Console.ReadKey();
        }
    }
}
