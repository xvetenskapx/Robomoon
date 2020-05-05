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
        // Bool if when aldready have created our characters
        public static bool CreatorNotRun = true;
        //
        // Characters properties
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
        public static int PlayerIndex;
        public static int RobomoonIndex;

        //
        // Creating of character
        //
        public Characters(string name, string race, int health, int attackdamage, int defence, Image apearence, Image deathapearence)
        {
            this.Name = name;
            this.Race = race;
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

        //
        // String method for orginal charcter
        //
        public string CharacterSpec()
        {
            return "Name: " + this.Name + "\r\n" +
                   "Race: " + this.Race + "\r\n" +
                   "Health: " + this.StartHealth + "\r\n" +
                   "AttackDamage: " + this.AttackDamage + "\r\n" +
                   "Defence: " + this.Defence;
        }
    }
}
