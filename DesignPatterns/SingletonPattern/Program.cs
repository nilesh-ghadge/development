using System;
/*
 * Ensure a class has one instance, and provide a global point of access to it
 *
 * Example: Login module where we want to invoke the module to perform log in only once
 */
namespace SingletonPattern
{
    class Program
    {
        static void Main()
        {
            var singleton = Singleton.GetInstance();
            singleton.Login();
            Console.ReadLine();
        }
    }
}
