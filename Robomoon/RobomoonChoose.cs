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
    //
    //
    //
    //
    //
    //
    // Fixa så att när Robomoon är död så avslutas spelet och Robomoon kan inte anfalla.
    //
    // Samt kolla ifall jag borde lägga en Random på HP, ATTADMG, DEF
    //
    // Varför stäng formen ner när jag trycker på Fight (händer ibland)
    //
    //
    //
    //
    //
    //
    //
    public partial class RobomoonChoose : Form
    {
        //
        // Character
        //
        //Random for the random character button
        new Random RandomCharacter = new Random();

        //Count if random button on or off
        int PlayableCharacterButtonRandom = 0;
        int EnemeyCharacterButtonRandom = 0;

        //Index for choosen character and enemy
        int playerindex;
        int enemeyindex;

        public RobomoonChoose()
        {
            InitializeComponent();

            //
            // Playable Character Creation
            //
            //André, Human
            Characters.PlayableCharacters.Add(new Characters("André", "Human", 26, 22, 15, Image.FromFile("Picture\\Characters\\Andre.bmp"), Image.FromFile("Picture\\Characters\\Defeted\\DefetedAndre.bmp")));
            lbxCharacterChoose.Items.Add(Characters.PlayableCharacters.ElementAt(0).Name);

            //Jesper, Human
            Characters.PlayableCharacters.Add(new Characters("Jesper", "Human", 18, 11, 22, Image.FromFile("Picture\\Characters\\Jesper.bmp"), Image.FromFile("Picture\\Characters\\Defeted\\DefetedJesper.bmp")));
            lbxCharacterChoose.Items.Add(Characters.PlayableCharacters.ElementAt(1).Name);

            //Wilma, Dog
            Characters.PlayableCharacters.Add(new Characters("Wilma", "Dog", 14, 22, 12, Image.FromFile("Picture\\Characters\\Wilma.bmp"), Image.FromFile("Picture\\Characters\\Defeted\\DefetedWilma.bmp")));
            lbxCharacterChoose.Items.Add(Characters.PlayableCharacters.ElementAt(2).Name);

            //
            // Robomoon Character Creation
            //
            //xvetenskapx, Robomoon
            Characters.RobomoonCharacters.Add(new Characters("xvetenskapx", "Robomoon", 21, 22, 17, Image.FromFile("Picture\\Robomoon\\André_H.bmp"), Image.FromFile("Picture\\Robomoon\\Defeted\\Defetedxvetenskapx.bmp")));
            lbxEnemyChoose.Items.Add(Characters.RobomoonCharacters.ElementAt(0).Name);

            //Nightking2002, Robomoon
            Characters.RobomoonCharacters.Add(new Characters("Nightking2002", "Robomoon", 23, 15, 27, Image.FromFile("Picture\\Robomoon\\Jesper_No.bmp"), Image.FromFile("Picture\\Robomoon\\Defeted\\DefetedNightking2002.bmp")));
            lbxEnemyChoose.Items.Add(Characters.RobomoonCharacters.ElementAt(1).Name);

            //Piggy, Pig
            Characters.RobomoonCharacters.Add(new Characters("Piggy", "Pig", 10, 22, 26, Image.FromFile("Picture\\Robomoon\\Piggy.bmp"), Image.FromFile("Picture\\Robomoon\\Defeted\\DefetedPiggy.bmp")));
            lbxEnemyChoose.Items.Add(Characters.RobomoonCharacters.ElementAt(2).Name);

            //Which is the first character to be shown
            lbxCharacterChoose.SelectedIndex = 2;
            lbxEnemyChoose.SelectedIndex = 2;

            this.BackgroundImage = Image.FromFile("Picture\\Other\\MenyBakcground.bmp");
        }

        private void RobomoonChoose_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lbxCharacterChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change between characters
            playerindex = lbxCharacterChoose.SelectedIndex;
            tbxCharacterTraits.Text = Characters.PlayableCharacters.ElementAt(playerindex).ToString();
            pbxCharacterAppearance.Image = Characters.PlayableCharacters.ElementAt(playerindex).Apearence;

            //Change index to desired character
            Characters.PlayerIndex = playerindex;
        }

        private void lbxEnemyChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change between Robomoons
            enemeyindex = lbxEnemyChoose.SelectedIndex;
            tbxEnemyTraits.Text = Characters.RobomoonCharacters.ElementAt(enemeyindex).ToString();
            pbxEnemyAppearance.Image = Characters.RobomoonCharacters.ElementAt(enemeyindex).Apearence;

            //Change index to desired Robomoons
            Characters.RobomoonIndex = enemeyindex;
        }

        private void btnRandomCharacter_Click(object sender, EventArgs e)
        {
            if (PlayableCharacterButtonRandom == 0)                             //Check so random is not on and turn on it
            {
                //Randomize character
                Characters.PlayerIndex = RandomCharacter.Next(0, Characters.PlayableCharacters.Count);
                
                //
                // Change button color
                //
                btnRandomCharacter.BackColor = Color.Green;
                PlayableCharacterButtonRandom++;
            }

            else                                                    //Go back to players choice of character
            {
                Characters.PlayerIndex = playerindex;

                //
                // Change button color
                //
                btnRandomCharacter.BackColor = Color.Red;
                PlayableCharacterButtonRandom--;
            }
        }

        private void btnRandomEnemy_Click(object sender, EventArgs e)
        {
            
            if (EnemeyCharacterButtonRandom == 0)           //Check so random is not on and turn on it
            {
                //Randomize Robomoon
                Characters.RobomoonIndex = RandomCharacter.Next(0, Characters.RobomoonCharacters.Count);

                //
                // Change button color
                //
                btnRandomEnemy.BackColor = Color.Green;
                EnemeyCharacterButtonRandom++;
            }
            else                                                    //Go back to players choice of Robomoon
            {
                Characters.RobomoonIndex = enemeyindex;
               
                //
                // Change button color
                //
                btnRandomEnemy.BackColor = Color.Red;
                EnemeyCharacterButtonRandom--;
            }
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            //Check so player do not play with a dead character
            if (pbxCharacterAppearance.Image == Characters.PlayableCharacters.ElementAt(Characters.PlayerIndex).DeathApearence)
            {
                MessageBox.Show("Character is defeted", "Dead character", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Check so player do not play against an already dead Robomoon
            else if (pbxEnemyAppearance.Image == Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).DeathApearence)
            {
                MessageBox.Show("Robomoon is defeted", "Dead robomoon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Open the fight form
                FightArena fightArena = new FightArena();
                fightArena.Show();


                // Hide this form
                this.Hide();
            }
        }
    }
}
