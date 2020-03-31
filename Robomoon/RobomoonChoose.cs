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
        List<Characters> PlayableCharacters = new List<Characters>();
        List<Characters> RobomoonCharacters = new List<Characters>();
        new Random RandomCharacter = new Random();
        int PlayableCharacterButtonRandom = 0;
        int EnemeyCharacterButtonRandom = 0;

        public RobomoonChoose()
        {
            InitializeComponent();
            //
            // Playable Character Creation
            //
            //André, Human
            PlayableCharacters.Add(new Characters("André", "Human", 15, 5, 10, Image.FromFile("Picture\\Characters\\Andre.bmp")));
            lbxCharacterChoose.Items.Add(PlayableCharacters.ElementAt(0).Name);

            //Jesper, Human
            PlayableCharacters.Add(new Characters("Jesper", "Human", 25, 15, 5, Image.FromFile("Picture\\Characters\\Jesper.bmp")));
            lbxCharacterChoose.Items.Add(PlayableCharacters.ElementAt(1).Name);

            //Wilma, Dog
            PlayableCharacters.Add(new Characters("Wilma", "Dog", 10, 10, 10, Image.FromFile("Picture\\Characters\\Wilma.bmp")));
            lbxCharacterChoose.Items.Add(PlayableCharacters.ElementAt(2).Name);

            //
            // Robomoon Character Creation
            //
            //xvetenskapx, Robomoon
            RobomoonCharacters.Add(new Characters("xvetenskapx", "Robomoon", 15, 15, 15, Image.FromFile("Picture\\Robomoon\\André_H.bmp")));
            lbxEnemyChoose.Items.Add(RobomoonCharacters.ElementAt(0).Name);

            //Nightking2002, Robomoon
            RobomoonCharacters.Add(new Characters("Nightking2002", "Robomoon", 15, 15, 15, Image.FromFile("Picture\\Robomoon\\Jesper_No.bmp")));
            lbxEnemyChoose.Items.Add(RobomoonCharacters.ElementAt(1).Name);

            //Piggy, Pig
            RobomoonCharacters.Add(new Characters("Piggy", "Pig", 15, 15, 15, Image.FromFile("Picture\\Robomoon\\Piggy.bmp")));
            lbxEnemyChoose.Items.Add(RobomoonCharacters.ElementAt(2).Name);

            lbxCharacterChoose.SelectedIndex = 0;
            lbxEnemyChoose.SelectedIndex = 1;
        }

        private void RobomoonChoose_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lbxCharacterChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxCharacterChoose.SelectedIndex;
            tbxCharacterTraits.Text = PlayableCharacters.ElementAt(index).ToString();
            pbxCharacterAppearance.Image = PlayableCharacters.ElementAt(index).Apearence;
        }

        private void lbxEnemyChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxEnemyChoose.SelectedIndex;
            tbxEnemyTraits.Text = RobomoonCharacters.ElementAt(index).ToString();
            pbxEnemyAppearance.Image = RobomoonCharacters.ElementAt(index).Apearence;
        }

        private void btnRandomCharacter_Click(object sender, EventArgs e)
        {
            if (PlayableCharacterButtonRandom == 0)
            {
                RandomCharacter.Next(0, PlayableCharacters.Count + 1);


                btnRandomCharacter.BackColor = Color.Green;
                PlayableCharacterButtonRandom++;
            }
            else
            {
                btnRandomCharacter.BackColor = Color.Red;
                PlayableCharacterButtonRandom--;
            }
        }

        private void btnRandomEnemy_Click(object sender, EventArgs e)
        {
            if (EnemeyCharacterButtonRandom == 0)
            {
                RandomCharacter.Next(0, RobomoonCharacters.Count + 1);


                btnRandomEnemy.BackColor = Color.Green;
                EnemeyCharacterButtonRandom++;
            }
            else
            {
                btnRandomEnemy.BackColor = Color.Red;
                EnemeyCharacterButtonRandom--;
            }
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            //
            FightArena fightArena = new FightArena();

            //Show open the fight form
            fightArena.Show();

            this.Hide();
        }
    }
}
