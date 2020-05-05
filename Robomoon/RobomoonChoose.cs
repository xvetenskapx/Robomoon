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

    public partial class RobomoonChoose : Form
    {
        //
        // Character
        //
        //Random for the random character button
        Random RandomCharacter = new Random();

        //Count if random button on or off
        int PlayableCharacterButtonRandom = 0;
        int EnemeyCharacterButtonRandom = 0;

        //Index for choosen character and enemy
        int playerindex;
        int enemeyindex;

        public RobomoonChoose()
        {
            InitializeComponent();
            if (Characters.CreatorNotRun)
            {
                Random CharacterStats = new Random();
                //
                // Playable Character Creation
                //
                //André, Human
                Characters.PlayableCharacters.Add(new Characters("André", "Human", CharacterStats.Next(10, 51), CharacterStats.Next(10, 51), CharacterStats.Next(10, 51), Image.FromFile("Picture\\Characters\\Andre.bmp"), Image.FromFile("Picture\\Characters\\Defeted\\DefetedAndre.bmp")));

                //Jesper, Human
                Characters.PlayableCharacters.Add(new Characters("Jesper", "Human", CharacterStats.Next(10, 51), CharacterStats.Next(10, 51), CharacterStats.Next(10, 51), Image.FromFile("Picture\\Characters\\Jesper.bmp"), Image.FromFile("Picture\\Characters\\Defeted\\DefetedJesper.bmp")));

                //Wilma, Dog
                Characters.PlayableCharacters.Add(new Characters("Wilma", "Dog", CharacterStats.Next(10, 51), CharacterStats.Next(10, 51), CharacterStats.Next(10, 51), Image.FromFile("Picture\\Characters\\Wilma.bmp"), Image.FromFile("Picture\\Characters\\Defeted\\DefetedWilma.bmp")));
                //
                // Robomoon Character Creation
                //
                //xvetenskapx, Robomoon
                Characters.RobomoonCharacters.Add(new Characters("xvetenskapx", "Robomoon", CharacterStats.Next(10, 51), CharacterStats.Next(10, 51), CharacterStats.Next(10, 51), Image.FromFile("Picture\\Robomoon\\André_H.bmp"), Image.FromFile("Picture\\Robomoon\\Defeted\\Defetedxvetenskapx.bmp")));

                //Nightking2002, Robomoon
                Characters.RobomoonCharacters.Add(new Characters("Nightking2002", "Robomoon", CharacterStats.Next(10, 51), CharacterStats.Next(10, 51), CharacterStats.Next(10, 51), Image.FromFile("Picture\\Robomoon\\Jesper_No.bmp"), Image.FromFile("Picture\\Robomoon\\Defeted\\DefetedNightking2002.bmp")));

                //Piggy, Pig
                Characters.RobomoonCharacters.Add(new Characters("Piggy", "Pig", CharacterStats.Next(10, 51), CharacterStats.Next(10, 51), CharacterStats.Next(10, 51), Image.FromFile("Picture\\Robomoon\\Piggy.bmp"), Image.FromFile("Picture\\Robomoon\\Defeted\\DefetedPiggy.bmp")));

                
            }

            int LiveCharacters = Characters.PlayableCharacters.Count;                                                                               //count of who many character are still ailve
            int LiveRobomoon = Characters.RobomoonCharacters.Count;                                                                                 //count of who many Robomoon are still ailve
            
            for (int i = 0; i < Characters.PlayableCharacters.Count; i++)                                                                           //put every character in the lisbox
            {
                lbxCharacterChoose.Items.Add(Characters.PlayableCharacters.ElementAt(i).Name);
                if (Characters.PlayableCharacters.ElementAt(i).Health == 0)
                {
                    LiveCharacters--;
                }
            }
            lbxCharacterChoose.SelectedIndex = 2;                                                                                                   //choose a first character
            
            for (int i = 0; i < Characters.RobomoonCharacters.Count; i++)                                                                           //put every robomoon in the listbox
            {
                lbxEnemyChoose.Items.Add(Characters.RobomoonCharacters.ElementAt(i).Name);
                if (Characters.RobomoonCharacters.ElementAt(i).Health == 0)
                {
                    LiveRobomoon--;
                }
            }
            lbxEnemyChoose.SelectedIndex = 2;                                                                                                       //choose a first robomoon
            
            if (LiveCharacters == 0)                                                                                                                //check if everyone is dead
            {
                MessageBox.Show("Every player character is dead, what a waste", "Noooo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnFight.Enabled = false;
                btnRandomCharacter.Enabled = false;
                btnRandomEnemy.Enabled = false;
            }
            else if (LiveRobomoon == 0)                                                                                                             //check if everyone is dead
            {
                MessageBox.Show("Every Robomoon is dead, So easy", "Yahoo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnFight.Enabled = false;
                btnRandomCharacter.Enabled = false;
                btnRandomEnemy.Enabled = false;
            }

            this.BackgroundImage = Image.FromFile("Picture\\Other\\MenyBakcground.bmp");                                                            //load in background
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
                while (true)
                {
                    Characters.PlayerIndex = RandomCharacter.Next(0, Characters.PlayableCharacters.Count);
                    if (Characters.PlayableCharacters.ElementAt(Characters.PlayerIndex).Health > 0)
                    {
                        //
                        // Change button color
                        //
                        btnRandomCharacter.BackColor = Color.Green;
                        PlayableCharacterButtonRandom++;

                        //Stop loop
                        break;
                    }
                }
                

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
                while (true)
                {
                    Characters.RobomoonIndex = RandomCharacter.Next(0, Characters.RobomoonCharacters.Count);
                    if (Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).Health > 0)
                    {
                        //
                        // Change button color
                        //
                        btnRandomEnemy.BackColor = Color.Green;
                        EnemeyCharacterButtonRandom++;

                        //stop loop
                        break;
                    }
                }


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
