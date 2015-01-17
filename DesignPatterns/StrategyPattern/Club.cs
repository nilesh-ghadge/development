using System;

namespace StrategyPattern
{
    public class Club : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Club");
        }
    }
}
