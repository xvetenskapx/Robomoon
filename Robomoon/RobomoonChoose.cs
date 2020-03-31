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
            RobomoonCharacters.Add(new Characters("xvetenskapx", "Robomoon", 15, 15, 15, Image.FromFile()))


            lbxCharacterChoose.SelectedIndex = 0;
        }

        private void btnVisaStatistik_Click(object sender, EventArgs e)
        {

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
    }
}
