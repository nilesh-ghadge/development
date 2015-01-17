using System;

namespace StrategyPattern
{
    public class Axe : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Axe");
        }
    }
}
