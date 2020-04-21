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
        new Random RandomCharacter = new Random();
        int PlayableCharacterButtonRandom = 0;
        int EnemeyCharacterButtonRandom = 0;
        int PlayableIndex;
        int EnemeyIndex;

        public RobomoonChoose()
        {
            InitializeComponent();
            //
            // Playable Character Creation
            //
            //André, Human
            Characters.PlayableCharacters.Add(new Characters("André", "Human", 15, 5, 10, Image.FromFile("Picture\\Characters\\Andre.bmp"), Image.FromFile("Picture\\Characters\\Defeted\\DefetedAndre.bmp")));
            lbxCharacterChoose.Items.Add(Characters.PlayableCharacters.ElementAt(0).Name);

            //Jesper, Human
            Characters.PlayableCharacters.Add(new Characters("Jesper", "Human", 25, 15, 5, Image.FromFile("Picture\\Characters\\Jesper.bmp"), Image.FromFile("Picture\\Characters\\Defeted\\DefetedJesper.bmp")));
            lbxCharacterChoose.Items.Add(Characters.PlayableCharacters.ElementAt(1).Name);

            //Wilma, Dog
            Characters.PlayableCharacters.Add(new Characters("Wilma", "Dog", 10, 10, 10, Image.FromFile("Picture\\Characters\\Wilma.bmp"), Image.FromFile("Picture\\Characters\\Defeted\\DefetedWilma.bmp")));
            lbxCharacterChoose.Items.Add(Characters.PlayableCharacters.ElementAt(2).Name);

            //
            // Robomoon Character Creation
            //
            //xvetenskapx, Robomoon
            Characters.RobomoonCharacters.Add(new Characters("xvetenskapx", "Robomoon", 15, 15, 15, Image.FromFile("Picture\\Robomoon\\André_H.bmp"), Image.FromFile("Picture\\Robomoon\\Defeted\\Defetedxvetenskapx.bmp")));
            lbxEnemyChoose.Items.Add(Characters.RobomoonCharacters.ElementAt(0).Name);

            //Nightking2002, Robomoon
            Characters.RobomoonCharacters.Add(new Characters("Nightking2002", "Robomoon", 15, 15, 15, Image.FromFile("Picture\\Robomoon\\Jesper_No.bmp"), Image.FromFile("Picture\\Robomoon\\Defeted\\DefetedNightking2002.bmp")));
            lbxEnemyChoose.Items.Add(Characters.RobomoonCharacters.ElementAt(1).Name);

            //Piggy, Pig
            Characters.RobomoonCharacters.Add(new Characters("Piggy", "Pig", 15, 15, 15, Image.FromFile("Picture\\Robomoon\\Piggy.bmp"), Image.FromFile("Picture\\Robomoon\\Defeted\\DefetedPiggy.bmp")));
            lbxEnemyChoose.Items.Add(Characters.RobomoonCharacters.ElementAt(2).Name);

            lbxCharacterChoose.SelectedIndex = 0;
            lbxEnemyChoose.SelectedIndex = 1;
        }

        private void RobomoonChoose_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lbxCharacterChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayableIndex = lbxCharacterChoose.SelectedIndex;
            tbxCharacterTraits.Text = Characters.PlayableCharacters.ElementAt(PlayableIndex).ToString();
            pbxCharacterAppearance.Image = Characters.PlayableCharacters.ElementAt(PlayableIndex).Apearence;

            Characters.PlayableIndex = PlayableIndex;
        }

        private void lbxEnemyChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnemeyIndex = lbxEnemyChoose.SelectedIndex;
            tbxEnemyTraits.Text = Characters.RobomoonCharacters.ElementAt(EnemeyIndex).ToString();
            pbxEnemyAppearance.Image = Characters.RobomoonCharacters.ElementAt(EnemeyIndex).Apearence;

            Characters.RobomoonIndex = EnemeyIndex;
        }

        private void btnRandomCharacter_Click(object sender, EventArgs e)
        {
            if (PlayableCharacterButtonRandom == 0)
            {
                Characters.PlayableIndex = RandomCharacter.Next(0, Characters.PlayableCharacters.Count);
                
                //
                // Button Propetis
                //
                btnRandomCharacter.BackColor = Color.Green;
                PlayableCharacterButtonRandom++;
            }
            else
            {
                Characters.PlayableIndex = PlayableIndex;

                //
                // Button Propetis
                //
                btnRandomCharacter.BackColor = Color.Red;
                PlayableCharacterButtonRandom--;
            }
        }

        private void btnRandomEnemy_Click(object sender, EventArgs e)
        {
            if (EnemeyCharacterButtonRandom == 0)
            {
                Characters.RobomoonIndex = RandomCharacter.Next(0, Characters.RobomoonCharacters.Count);

                //
                // Button Propetis
                //
                btnRandomEnemy.BackColor = Color.Green;
                EnemeyCharacterButtonRandom++;
            }
            else
            {
                Characters.RobomoonIndex = EnemeyIndex;
                //
                // Button Propetis
                //
                btnRandomEnemy.BackColor = Color.Red;
                EnemeyCharacterButtonRandom--;
            }
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            if (pbxCharacterAppearance.Image == Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).DeathApearence)
            {
                MessageBox.Show("Character is defeted", "Dead character", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pbxEnemyAppearance.Image == Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).DeathApearence)
            {
                MessageBox.Show("Robomoon is defeted", "Dead robomoon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Show open the fight form
                FightArena fightArena = new FightArena();
                fightArena.Show();

                // Hide This From
                this.Hide();
            }
        }
    }
}
