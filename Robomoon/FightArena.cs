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
    public partial class FightArena : Form
    {
        public FightArena()
        {
            InitializeComponent();
            RobomoonChoose.ActiveForm.Dispose();
            int StartHealth = Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).AttackDamage;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //
            // brush propetis
            //
            Graphics g = e.Graphics;
            SolidBrush LightBrush = new SolidBrush(Color.FromArgb(170, 175, 144));
            SolidBrush DarkBrush = new SolidBrush(Color.FromArgb(200, 200, 176));
            SolidBrush LoadingGreen = new SolidBrush(Color.Green);
            Pen Test = new Pen(Color.BlueViolet, 10f);
            //
            // Yttre Fiende Ovalen
            //  
            g.FillEllipse(DarkBrush, 1000, 130, 820, 206);
            //
            // Inre Fiende Ovalen
            //
            g.FillEllipse(LightBrush, 1010, 140, 800, 186);
            //
            // Yttre Spelare Ovalen
            //  
            g.FillEllipse(DarkBrush, 100, 385, 820, 206);
            //
            // Inre Spelare Ovalen
            //
            g.FillEllipse(LightBrush, 110, 395, 800, 186);
        }


        private void FightArena_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btnFight_Click(object sender, EventArgs e)
        {
            gbxDecideAction.Hide();

            gbxFight.Visible = true;
            gbxFight.Location = new Point(95, 60);

            lblText.Font = new Font("Microsoft Sans Serif", 50);
            lblText.Text = "What Combat Technique Were You Thinking Of Using?";
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't run, keep fighting until you die", "NO, YOU CAN'T RUN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void btnGoBack_Click(object sender, EventArgs e)
        {
            gbxFight.Visible = false;
            gbxDecideAction.Visible = true;

            lblText.Font = new Font("Microsoft Sans Serif", 50);
            lblText.Text = "What Are You Going To Do?";
        }

        private void FightArena_Load(object sender, EventArgs e)
        {
            pbxCharacter.Image = Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).Apearence;
            pbxRobomoon.Image = Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).Apearence;

            //
            // Character
            //
            lblCharacterName.Text = Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).Name;
            pbrCharacterHP.Value = 100;
            lblCharacterHP.Text = Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).Health.ToString() + "/" + Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).Health.ToString();
            //
            // Robomoon
            //
            lblRobomoonNamn.Text = Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).Name;
            pbrRobomoonHP.Value = 100;
            //
            // Text
            //
            lblText.Font = new Font("Microsoft Sans Serif", 50);
            lblText.Text = "What Are You Going To Do?";
        }

        private void btnBackpack_Click(object sender, EventArgs e)
        {
            gbxDecideAction.Hide();

            gbxBackpack.Visible = true;
            gbxBackpack.Location = new Point(95, 60);

            lblText.Font = new Font("Microsoft Sans Serif", 40);
            lblText.Text = "This Is What You Have In Your Backpack";
        }

        private void btnGoBackBackpack_Click(object sender, EventArgs e)
        {
            gbxBackpack.Visible = false;
            gbxDecideAction.Visible = true;

            lblText.Font = new Font("Microsoft Sans Serif", 50);
            lblText.Text = "What Are You Going To Do?";
        }

        private void btnCharacter_Click(object sender, EventArgs e)
        {
            gbxDecideAction.Hide();

            gbxSpec.Visible = true;
            gbxSpec.Location = new Point(95, 60);

            lblCharacterSpec.Text = Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).ToString();
            lblRobomoonSpec.Text = Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).ToString();

            lblText.Font = new Font("Microsoft Sans Serif", 50);
            lblText.Text = "Here Is Your And His Specs";
        }

        private void btnGoBackSpecs_Click(object sender, EventArgs e)
        {
            gbxSpec.Visible = false;
            gbxDecideAction.Visible = true;

            lblText.Font = new Font("Microsoft Sans Serif", 50);
            lblText.Text = "What Are You Going To Do?";
        }
    }
}
