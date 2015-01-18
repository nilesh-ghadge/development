using System;
using InteratorPattern.Aggregate;
using InteratorPattern.Iterator;

namespace InteratorPattern
{
    class Program
    {
        static void Main()
        {
            var facebook = new Facebook();
            var twitter = new Twitter();

            var fbIterator = facebook.CreateIterator();
            var twIterator = twitter.CreateIterator();

            Console.WriteLine("Facebook Users:");
            PrintUsers(fbIterator);
            Console.WriteLine("");
            Console.WriteLine("Twitter Users:");
            PrintUsers(twIterator);

            Console.ReadKey();
        }

        private static void PrintUsers(IIterator iterator)
        {
            iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine("{0}", iterator.Next());
            }
        }
    }
}
