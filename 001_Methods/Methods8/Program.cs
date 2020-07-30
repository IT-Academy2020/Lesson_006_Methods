using System;
using System.Text;

// Приклад: Використання вартового оператора, для захисту коректного виконання метода.

namespace Methods
{
    class Program
    {
        static string Function(string name)
        {
            // Виконуємо перевірку. При виявленні помилок завершуємо роботу.

            if (name == "fool")   // Вартовий оператор.
            {
                return "Ви використовували неприпустиме слово.";
            }

            string sentence = "Hello " + name + "!";

            return sentence;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            string sentence = Function("fool");

            Console.WriteLine(sentence);

            // Delay.
            Console.ReadKey();
        }
    }
}
