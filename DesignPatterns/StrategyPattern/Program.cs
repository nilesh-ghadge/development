using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main()
        {
            IWeapon weapon = null;
            var testCharacter = new Character();
            while (true)
            {
                Console.WriteLine("Choose a Weapon for your character (1 = Sword, 2 = Axe, 3 = Club):");
                var input = Console.ReadLine();
         
                switch (input)
                {
                    case "1":
                        weapon = new Sword();
                        break;
                    case "2":
                        weapon = new Axe();
                        break;
                    case "3":
                        weapon = new Club();
                        break;
                }
                testCharacter.SetWeapon(weapon);
                testCharacter.Attack();
            }
        }
    }
}
