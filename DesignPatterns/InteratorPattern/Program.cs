using System;
using InteratorPattern.Aggregate;
using InteratorPattern.Iterator;


/*
 * The iterator pattern is a design pattern in which an iterator is used to traverse a container and access the container's elements. 
 * The iterator pattern decouples algorithms from containers; in some cases, algorithms are necessarily container-specific and thus cannot be decoupled.
 * The essence of the Iterator Factory method Pattern is to "Provide a way to access the elements of an aggregate object sequentially without exposing its 
 * underlying representation.
 *
 * Example: Merger of Facebook & Twitter and need to traverse through the list of users
 */
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
