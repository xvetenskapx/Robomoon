using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robomoon
{
    class Robomoons
    {
        //Robomoons Characters
        public string Name;
        public string Race;
        public int Health;
        public int AttackDamage;
        public int Defence;

        public Robomoons(string name, string race, int health, int attackdamage, int defence)
        {
            this.Name = name;
            this.Race = race;
            switch (Race)
            {
                case "Human":
                    Health += 10;
                    AttackDamage += 10;
                    Defence += 10;
                    break;
                default:
                    break;
            }
            this.Health += health;
            this.AttackDamage += attackdamage;
            this.Defence += defence;

        }
        //Konstruktor - kod som körs när vi ksapar ett objekt

        public override string ToString()
        {
            return "Name: " + this.Name + "\r\n" +
                   "Race: " + this.Race + "\r\n" + 
                   "Health: " + this.Health + "\r\n" + 
                   "AttackDamage: " + this.AttackDamage + "\r\n" +
                   "Defence: " + this.Defence;
        }

    }
}
