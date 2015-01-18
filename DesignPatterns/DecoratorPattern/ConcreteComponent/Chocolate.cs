
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    public class Chocolate : IceCream
    {
        public override double Cost()
        {
            return 1.00;
        }
    }
}
