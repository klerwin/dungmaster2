using System;
namespace DungeonMaster2
{
    public class Creature
    {
        public int hp = 100; // "public int" gör den tillgänglig i andra klasser
        public int atk = 12;
        public int def = 10;
        public int dmg = 7;

        // innanför () är constructorns parameter
        // constructorn skapar ett objectet  
        public Creature(int hpInput, int atkInput, int defInput, int dmgInput) // "Creature"s constructor börjar här, om du skriver new Creature(); någon annanstans körs koden här i
        {
            hp = hpInput;
            atk = atkInput;
            def = defInput;
            dmg = dmgInput;
        }

        public Creature() // här har constructorn ingen parameter och måste
        {

        }
    }
}
