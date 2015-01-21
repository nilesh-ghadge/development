
using System;

namespace AdapterPattern
{

    public class Translator
    {
        readonly Hindi _hindi = new Hindi();

        public void Translate(string words)
        {
            switch (words.ToLower())
            {
                case "hello":
                    _hindi.Greet();
                    break;

                case "bye":
                    _hindi.Bid();
                    break;

                default:
                    Console.WriteLine("Cannot be translated");
                    break;
            }
        }
    }
}
