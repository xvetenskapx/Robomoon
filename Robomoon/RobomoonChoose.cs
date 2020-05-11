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
                //
                // Playable Character Creation
                //
                //André, Human
                Characters.PlayableCharacters.Add(new Characters("André", "Human", StartMeny.RandomStat.Next(10, 51), StartMeny.RandomStat.Next(10, 51), StartMeny.RandomStat.Next(10, 51), Image.FromFile("Picture\\Characters\\Andre.bmp"), Image.FromFile("Picture\\Characters\\Defeted\\DefetedAndre.bmp")));

                //Jesper, Human
                Characters.PlayableCharacters.Add(new Characters("Jesper", "Human", StartMeny.RandomStat.Next(10, 51), StartMeny.RandomStat.Next(10, 51), StartMeny.RandomStat.Next(10, 51), Image.FromFile("Picture\\Characters\\Jesper.bmp"), Image.FromFile("Picture\\Characters\\Defeted\\DefetedJesper.bmp")));

                //Wilma, Dog
                Characters.PlayableCharacters.Add(new Characters("Wilma", "Dog", StartMeny.RandomStat.Next(10, 51), StartMeny.RandomStat.Next(10, 51), StartMeny.RandomStat.Next(10, 51), Image.FromFile("Picture\\Characters\\Wilma.bmp"), Image.FromFile("Picture\\Characters\\Defeted\\DefetedWilma.bmp")));
                //
                // Robomoon Character Creation
                //
                //xvetenskapx, Robomoon
                Characters.RobomoonCharacters.Add(new Characters("xvetenskapx", "Robomoon", StartMeny.RandomStat.Next(10, 51), StartMeny.RandomStat.Next(10, 51), StartMeny.RandomStat.Next(10, 51), Image.FromFile("Picture\\Robomoon\\André_H.bmp"), Image.FromFile("Picture\\Robomoon\\Defeted\\Defetedxvetenskapx.bmp")));

                //Nightking2002, Robomoon
                Characters.RobomoonCharacters.Add(new Characters("Nightking2002", "Robomoon", StartMeny.RandomStat.Next(10, 51), StartMeny.RandomStat.Next(10, 51), StartMeny.RandomStat.Next(10, 51), Image.FromFile("Picture\\Robomoon\\Jesper_No.bmp"), Image.FromFile("Picture\\Robomoon\\Defeted\\DefetedNightking2002.bmp")));

                //Piggy, Pig
                Characters.RobomoonCharacters.Add(new Characters("Piggy", "Pig", StartMeny.RandomStat.Next(10, 51), StartMeny.RandomStat.Next(10, 51), StartMeny.RandomStat.Next(10, 51), Image.FromFile("Picture\\Robomoon\\Piggy.bmp"), Image.FromFile("Picture\\Robomoon\\Defeted\\DefetedPiggy.bmp")));
            }

            //count of who many character are still ailve
            int LiveCharacters = Characters.PlayableCharacters.Count;
            //count of who many Robomoon are still ailve
            int LiveRobomoon = Characters.RobomoonCharacters.Count;

            //put every character in the lisbox
            for (int i = 0; i < Characters.PlayableCharacters.Count; i++)
            {
                LbxCharacterChoose.Items.Add(Characters.PlayableCharacters.ElementAt(i).Name);
                if (Characters.PlayableCharacters.ElementAt(i).Health == 0)
                {
                    LiveCharacters--;
                }
            }
            //choose a first character
            LbxCharacterChoose.SelectedIndex = 2;

            //put every robomoon in the listbox
            for (int i = 0; i < Characters.RobomoonCharacters.Count; i++)
            {
                LbxEnemyChoose.Items.Add(Characters.RobomoonCharacters.ElementAt(i).Name);
                if (Characters.RobomoonCharacters.ElementAt(i).Health == 0)
                {
                    LiveRobomoon--;
                }
            }
            //choose a first robomoon
            LbxEnemyChoose.SelectedIndex = 2;

            //check if everyone is dead
            if (LiveCharacters == 0)
            {
                StartMeny.DUN.Play();
                MessageBox.Show("Every player character is dead, what a waste", "Noooo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BtnFight.Enabled = false;
                BtnRandomCharacter.Enabled = false;
                BtnRandomEnemy.Enabled = false;
            }

            //check if everyone is dead
            else if (LiveRobomoon == 0)
            {
                MessageBox.Show("Every Robomoon is dead, So easy", "Yahoo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BtnFight.Enabled = false;
                BtnRandomCharacter.Enabled = false;
                BtnRandomEnemy.Enabled = false;
            }

            //load in background
            this.BackgroundImage = Image.FromFile("Picture\\Other\\MenyBakcground.bmp");
        }

        private void RobomoonChoose_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LbxCharacterChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change between characters
            playerindex = LbxCharacterChoose.SelectedIndex;
            TbxCharacterTraits.Text = Characters.PlayableCharacters.ElementAt(playerindex).ToString();
            PbxCharacterAppearance.Image = Characters.PlayableCharacters.ElementAt(playerindex).Apearence;

            //Change index to desired character
            Characters.PlayerIndex = playerindex;
        }

        private void LbxEnemyChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change between Robomoons
            enemeyindex = LbxEnemyChoose.SelectedIndex;
            TbxEnemyTraits.Text = Characters.RobomoonCharacters.ElementAt(enemeyindex).ToString();
            PbxEnemyAppearance.Image = Characters.RobomoonCharacters.ElementAt(enemeyindex).Apearence;

            //Change index to desired Robomoons
            Characters.RobomoonIndex = enemeyindex;
        }

        private void BtnRandomCharacter_Click(object sender, EventArgs e)
        {
            //Check so random is not on and turn on it
            if (PlayableCharacterButtonRandom == 0)
            {
                //Randomize character
                while (true)
                {
                    Characters.PlayerIndex = StartMeny.RandomStat.Next(0, Characters.PlayableCharacters.Count);
                    if (Characters.PlayableCharacters.ElementAt(Characters.PlayerIndex).Health > 0)
                    {
                        //
                        // Change button color
                        //
                        BtnRandomCharacter.BackColor = Color.Green;
                        PlayableCharacterButtonRandom++;

                        //Stop loop
                        break;
                    }
                }
                

            }

            //Go back to players choice of character
            else
            {
                Characters.PlayerIndex = playerindex;

                //
                // Change button color
                //
                BtnRandomCharacter.BackColor = Color.Red;
                PlayableCharacterButtonRandom--;
            }
        }

        private void BtnRandomEnemy_Click(object sender, EventArgs e)
        {
            //Check so random is not on and turn on it
            if (EnemeyCharacterButtonRandom == 0)           
            {
                //Randomize Robomoon
                while (true)
                {
                    Characters.RobomoonIndex = StartMeny.RandomStat.Next(0, Characters.RobomoonCharacters.Count);
                    if (Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).Health > 0)
                    {
                        //
                        // Change button color
                        //
                        BtnRandomEnemy.BackColor = Color.Green;
                        EnemeyCharacterButtonRandom++;

                        //stop loop
                        break;
                    }
                }


            }

            //Go back to players choice of Robomoon
            else
            {
                Characters.RobomoonIndex = enemeyindex;
               
                //
                // Change button color
                //
                BtnRandomEnemy.BackColor = Color.Red;
                EnemeyCharacterButtonRandom--;
            }
        }

        private void BtnFight_Click(object sender, EventArgs e)
        {
            //Check so player do not play with a dead character
            if (PbxCharacterAppearance.Image == Characters.PlayableCharacters.ElementAt(Characters.PlayerIndex).DeathApearence)
            {
                MessageBox.Show("Character is defeted", "Dead character", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Check so player do not play against an already dead Robomoon
            else if (PbxEnemyAppearance.Image == Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).DeathApearence)
            {
                MessageBox.Show("Robomoon is defeted", "Dead robomoon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StartMeny.Yahoo.Play();

                //Open the fight form
                FightArena fightArena = new FightArena();
                fightArena.Show();

                // Hide this form
                this.Hide();
            }
        }
    }
}
