using System;

// Методи (Функції).

namespace Methods
{
    class Program
    {
        // На 13-му рядку, створюємо метод з іменем Function, який приймає один стрічковий аргумент і повертає стрічкове значення.
        // У тілі методу, стрічковій локальній змінній sentence, присвоюємо конкатенацію рядків і аргументу,
        // використовуючи ключове слово return, повертаємо значення змінної sentence.

        static string Function(string name)
        {
            string sentence = "Hello " + name + "!";

            return sentence;
        }

        static void Main()
        {
            // У тілі методу Main на 25-му рядку, створюємо стрічкову локальну змінну з іменем sentence,
            // присвоюємо їй значення, що повертається з методу Function, якому в якості аргументу передаємо рядок - Alex.
            string sentence = Function("Alex");

            Console.WriteLine(sentence);

            // Delay.
            Console.ReadKey();
        }
    }
}
