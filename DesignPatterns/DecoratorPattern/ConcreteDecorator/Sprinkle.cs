
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    public class Sprinkle : Toppings
    {
        public Sprinkle(IceCream s) : base(s)
        {
            
        }

        public override double Cost()
        {
            return 0.30 + IceCream.Cost();
        }
    }
}
