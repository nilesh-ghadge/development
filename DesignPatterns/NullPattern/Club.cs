using System;

namespace NullPattern
{
    public class Club : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Club");
        }
    }
}
