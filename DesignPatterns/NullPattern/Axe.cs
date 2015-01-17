using System;

namespace NullPattern
{
    public class Axe : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Axe");
        }
    }
}
