using System;

// Методи (Процедури).

namespace Methods
{
    class Program
    {
        // На 12-му рядку, створюємо метод з іменем Procedure, який нічого не приймає і нічого не повертає.
        // У тілі методу, на 14-му рядку виводимо на екран рядок - Hello!     

        static void Procedure()
        {
            Console.WriteLine("Hello!");
        }

        static void Main()
        {
            // У тілі методу Main на 21-му рядку, викликаємо метод Procedure.

            Procedure();

            // Delay.
            Console.ReadKey();
        }
    }
}
