using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    public abstract class Toppings : IceCream
    {
        protected IceCream IceCream;
        protected Toppings(IceCream s)
        {
            IceCream = s;
        }
    }
}
