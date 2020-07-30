using System;
using System.Text;

namespace Methods
{
    class Program
    {
        // Параметр, який передається за значенням, після завершення метода.
        static void AddTwo(int a)
        {
            a = a + 2;
            Console.WriteLine("Значення int a = {0}", a);
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть число:");

            // Приймаємо введені дані від користувача і перетворимо їх в цілочисельне значення
            
            string number = Console.ReadLine();
            int result = Int32.Parse(number);

            Console.WriteLine("Значення result = {0}", result);

            // Як аргумент передається не сама змінна - result, а її копія, змінна не змінюється після виконання метода.
            AddTwo(result);
            Console.WriteLine("Значення result = {0}", result); 

            // Delay.
            Console.ReadKey();
        }
    }
}
