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
        //
        // Robomoons Characters
        //
        public string Name;
        public string Race;
        public int Health;
        public int StartHealth;
        public int AttackDamage;
        public int Defence;
        public Image Apearence;
        public Image DeathApearence;
        //
        // Character List
        //
        public static List<Characters> PlayableCharacters = new List<Characters>();
        public static List<Characters> RobomoonCharacters = new List<Characters>();
        //
        // Selected Character
        //
        public static int PlayableIndex;
        public static int RobomoonIndex;
        
        public Characters(string name, string race, int health, int attackdamage, int defence, Image apearence, Image deathapearence)
        {
            this.Name = name;
            this.Race = race;
            //switch (Race)
            //{
            //    case "Human":
            //        Health += 10;
            //        AttackDamage += 10;
            //        Defence += 10;
            //        break;
            //    default:
            //        break;
            //}
            this.Health = health;
            this.StartHealth = health;
            this.AttackDamage = attackdamage;
            this.Defence = defence;
            this.Apearence = apearence;
            this.DeathApearence = deathapearence;

        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\r\n" +
                   "Race: " + this.Race + "\r\n" + 
                   "Health: " + this.Health + "\r\n" + 
                   "AttackDamage: " + this.AttackDamage + "\r\n" +
                   "Defence: " + this.Defence;
        }

        public string CharacterSpec()
        {
            return "Name: " + this.Name + "\r\n" +
                   "Race: " + this.Race + "\r\n" +
                   "Health: " + this.StartHealth + "\r\n" +
                   "AttackDamage: " + this.AttackDamage + "\r\n" +
                   "Defence: " + this.Defence;
        }
    }

    class SelectedItems
    {
        //
        public int SelectedCharacter;
        public int SelectedEnemy;
        //public int Friend0Foe1;

        public SelectedItems(int selecteditem, int friend0foe1)
        {
            if (friend0foe1 == 0)
            {
                this.SelectedCharacter = selecteditem;
            }
            else if (friend0foe1 == 1)
            {
                this.SelectedEnemy = selecteditem;
            }
            
        }
    }
}
