using System;

namespace StrategyPattern
{
    public class Sword : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Sword");
        }
    }
}
