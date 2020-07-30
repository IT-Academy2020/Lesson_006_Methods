using System;

// Методи (Функції).

namespace Methods
{
    class Program
    {
        // На 12-му рядку, створюємо метод з іменем Function, який нічого не приймає і повертає стрічкове значення.
        // У тілі методу, використовуючи ключове слово return, повертаємо рядок - Hello!

        static string Function()
        {
            return "Hello!";
        }

        static void Main()
        {
            // У тілі методу Main на 22-му рядку, створюємо стрічкову локальну змінну з ім'ям @string
            // і присвоюємо їй значення, що повертається методом Function.

            string @string = Function();
                       
            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();
        }
    }
}
