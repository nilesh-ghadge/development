using System;
using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;


/*
 *  is a design pattern that allows behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other 
 *  objects from the same class
 * 
 *  Example: Icecream and toppings
 */
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
