using System;

namespace NullPattern
{
    public class Sword : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Sword");
        }
    }
}
