using System;

/*
  the strategy pattern (also known as the policy pattern) is a software design pattern that enables an algorithm's behavior to be selected at runtime. 
 * 
 * Example: Game where a character uses different weapons with different attack capabilities
 */

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
