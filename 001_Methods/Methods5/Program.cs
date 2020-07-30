using System;

// Методи (Функції).

namespace Methods
{
    class Program
    {
        /// <summary>
        /// Додавання двох цілих чисел.
        /// </summary>
        /// <param name="summand1">Перший доданок</param>
        /// <param name="summand2">Другий доданок</param>
        /// <returns>Сума</returns>
        static int Add(int summand1, int summand2)
        {
            return summand1 + summand2;
        }

        static void Main()
        {
            int summand1 = 2, summand2 = 3;

            int sum = Add(summand1, summand2);

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            // Delay.
            Console.ReadKey();
        }
    }
}
