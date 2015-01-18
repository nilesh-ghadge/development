
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    public class Fudge : Toppings
    {
        public Fudge(IceCream s) : base(s)
        {
            
        }
        public override double Cost()
        {
            return 0.20 + IceCream.Cost();
        }
    }
}
