using System;

namespace NullPattern
{
    public class NullClass: IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Null object encountered!!");
        }
    }
}
