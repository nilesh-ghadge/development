using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main()
        {
            var translator = new Translator();
            Console.WriteLine("Enter a word to be transalated to Hindi:");
            var sentence = Console.ReadLine();
            translator.Translate(sentence);
            Console.ReadKey();
        }
    }
}
