
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    public class Vanilla : IceCream
    {
        public override double Cost()
        {
            return .75;
        }
    }
}
