using System;
using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;

namespace DecoratorPattern
{
    class Program
    {
        static void Main()
        {
            IceCream iceCream = new Chocolate();
            iceCream = new Sprinkle(iceCream);
            iceCream = new Fudge(iceCream);

            Console.WriteLine("Total Price: {0}",iceCream.Cost());
            Console.ReadKey();
        }
    }
}
