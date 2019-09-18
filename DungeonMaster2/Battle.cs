using System;
namespace DungeonMaster2
{
    public class Battle
    {
        public Battle()
        {
            Creature Gorilla = new Creature(90, 7, 9, 6);
            Creature Hero = new Creature(100, 6, 12, 7);

            Random rnd = new Random();

            Console.WriteLine("Welcome to hero VS gorilla!\n");
            Console.WriteLine("Press enter to begin.");
            Console.ReadLine();

            while (true)
            {
                int diceRoll = rnd.Next(1, 21);

                Console.WriteLine("Hero attacks!");
                if (diceRoll + Hero.atk > Gorilla.def)
                {
                    Gorilla.hp = Gorilla.hp - Hero.dmg;
                    Console.WriteLine($"Hit! Monster hp left: {Gorilla.hp}");
                }
                else
                {
                    Console.WriteLine("Miss");

                }
                Console.ReadLine();

                if (Gorilla.hp < 1)
                {
                    Console.WriteLine("Monster died!");
                    break;
                }

                diceRoll = rnd.Next(1, 21);

                Console.WriteLine("Monster attacks!");
                if (diceRoll + Gorilla.atk > Hero.def)
                {
                    Hero.hp = Hero.hp - Gorilla.dmg;
                    Console.WriteLine($"Hit! Hero hp left: {Hero.hp}");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
                Console.ReadLine();

                if (Hero.hp < 1)
                {
                    Console.WriteLine("Hero died!");
                    break;
                }


            }
        }
    }
}
