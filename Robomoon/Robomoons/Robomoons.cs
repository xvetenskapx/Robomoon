using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Robomoon
{
    class Characters
    {
        //Robomoons Characters
        public string Name;
        public string Race;
        public int Health;
        public int AttackDamage;
        public int Defence;
        public Image Apearence;
       

        public Characters(string name, string race, int health, int attackdamage, int defence, Image apearence)
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
            this.Apearence = apearence;

        }

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
