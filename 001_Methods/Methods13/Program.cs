using System;
using System.Text;

namespace Methods
{
    class Program
    {
        // Передається посилання на аргумент копія не створюється.
        static void AddTwo(ref int a)
        {
            a = a + 2;
            Console.WriteLine("Значення int a = {0}", a);
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть число:");

            // Приймаємо введенні дані від користувача і перетворюємо їх в цілочисельне значення
            
            string number = Console.ReadLine();
            int result = Int32.Parse(number);

            Console.WriteLine("Значення result = {0}", result);

            // У якості аргумента передається посилання на змінну - result, а не її копія.
            AddTwo(ref result);
            Console.WriteLine("Значення result = {0}", result);

            // Delay.
            Console.ReadKey();
        }
    }
}
