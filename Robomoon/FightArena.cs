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
        //int StartHealth = Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).Health;
        
        // Ändra Det måste var det absoluta start livet. Extra int i Classen bara
        int PlayerStartHealth = -1;
        int EnemyStartHealth = -1;

        public FightArena()
        {
            InitializeComponent();
            RobomoonChoose.ActiveForm.Dispose();
            PlayerStartHealth = Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).Health;
            EnemyStartHealth = Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).Health;
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
            lblCharacterHP.Text = Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).Health.ToString() + "/" + PlayerStartHealth;
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
            //
            // Testing
            //
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

        private void btnAttack1_Click(object sender, EventArgs e)
        {
            //
            // I Fight
            //
            // Attack
            Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).Health += -5;
            //Health Update
            HealthCheck(Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex));
            pbrRobomoonHP.Value = Healthbar(Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex));
            //
            // Robomoon Fight
            //
            RobomoonFight();
            HealthCheck(Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex));
            pbrCharacterHP.Value = Healthbar(Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex));
            //
            // Go Back
            //
            gbxFight.Visible = false;
            gbxDecideAction.Visible = true;

            lblText.Font = new Font("Microsoft Sans Serif", 50);
            lblText.Text = "What Are You Going To Do?";

        }

        private void btnAttack2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmera Knappen", "Inte Programmerad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAttack3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmera Knappen", "Inte Programmerad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAttack4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmera Knappen", "Inte Programmerad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAttack5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmera Knappen", "Inte Programmerad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        void HealthCheck (Characters characters)
        {
            //
            // Robomoon Health Update
            //
            if (characters == Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex))
            {
                if (Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).Health <= 0)
                {
                    Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).Apearence = Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).DeathApearence;
                    pbxRobomoon.Image = Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).Apearence;
                    RobomoonChoose choose = new RobomoonChoose();
                    choose.Show();
                    this.Hide();
                    //////int NumberDefeted = 0;
                    //////for (int i = 0; i < Characters.RobomoonCharacters.Count; i++)
                    //////{
                    //////    if (Characters.RobomoonCharacters.ElementAt(i).Apearence == Characters.RobomoonCharacters.ElementAt(i).DeathApearence)
                    //////    {
                    //////        NumberDefeted++;
                    //////    }
                    //////}
                    //////if (Characters.RobomoonCharacters.Count == NumberDefeted)
                    //////{
                    //////    MessageBox.Show("Well everyone is defeted, What a waste of time", "Dead", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //////}
                }
            }

            else if (characters == Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex))
            {
                if (Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).Health <= 0)
                {
                    Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).Apearence = Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).DeathApearence;
                    pbxCharacter.Image = Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).Apearence;

                    RobomoonChoose choose = new RobomoonChoose();
                    choose.Show();
                    this.Hide();

                    //////NumberDefeted = 0;
                    //////for (int i = 0; i < Characters.PlayableCharacters.Count; i++)
                    //////{
                    //////    if (Characters.PlayableCharacters.ElementAt(i).Apearence == Characters.PlayableCharacters.ElementAt(i).DeathApearence)
                    //////    {
                    //////        NumberDefeted++;
                    //////    }
                    //////}
                    //////if (Characters.PlayableCharacters.Count == NumberDefeted)
                    //////{
                    //////    MessageBox.Show("You are defeted, What a waste of time", "Dead", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //////}
                }
            }

        }

        void RobomoonFight()
        {
            Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).Health += -5;
            lblCharacterHP.Text = Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).Health.ToString() + "/" + PlayerStartHealth; 
            //HealthCheck(Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex));
        }

        int Healthbar (Characters characters)
        {
            double playerstarterhealth = double.Parse(PlayerStartHealth.ToString());
            double enemystarterhealth = double.Parse(EnemyStartHealth.ToString());
            double CurrentHealth = -1;
            double PercentageHealth = -1;

            //
            // Robomoon Health Percentage
            //
            if (characters == Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex))
            {
                CurrentHealth = double.Parse(Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex).Health.ToString());
                PercentageHealth = ((CurrentHealth / enemystarterhealth) * 100) + 0.5;

                if (PercentageHealth <= 0)
                {
                    return 0;
                }

                return (int)PercentageHealth;
            }
            //
            // Character Health Percentage
            //
            else if (characters == Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex))
            {
                CurrentHealth = double.Parse(Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex).Health.ToString());
                PercentageHealth = ((CurrentHealth / playerstarterhealth) * 100) + 0.5;

                if (PercentageHealth <= 0)
                {
                    return 0;
                }
                
                return (int)PercentageHealth;
            }
            //
            // Back up
            //
            else
            {
                return int.Parse(CurrentHealth.ToString());
            }
            
        }
    }
}
