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
        Characters Player = Characters.PlayableCharacters.ElementAt(Characters.PlayableIndex);
        Characters Enemey = Characters.RobomoonCharacters.ElementAt(Characters.RobomoonIndex);

        int PlayerStartHealth = -1;
        int EnemyStartHealth = -1;


        public FightArena()
        {
            InitializeComponent();
            RobomoonChoose.ActiveForm.Dispose();

            PlayerStartHealth = Player.StartHealth;
            EnemyStartHealth = Enemey.StartHealth;


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


        private void FightArena_Load(object sender, EventArgs e)
        {
            pbxCharacter.Image = Player.Apearence;
            pbxRobomoon.Image = Enemey.Apearence;

            //
            // Character
            //
            lblCharacterName.Text = Player.Name;
            pbrCharacterHP.Value = Healthbar(Player);
            lblCharacterHP.Text = Player.Health.ToString() + "/" + PlayerStartHealth;
            //
            // Robomoon
            //
            lblRobomoonNamn.Text = Enemey.Name;
            pbrRobomoonHP.Value = Healthbar(Enemey);
            //
            // Text
            //
            lblText.Font = new Font("Microsoft Sans Serif", 50);
            lblText.Text = "What Are You Going To Do?";
            //
            // FightButtons Name
            //
            btnAttack1.Text = "Standard";
            btnAttack2.Text = "Slap from doom";
            btnAttack5.Text = "ARK";
        }


        //
        // Group Box Decide Action
        //
        private void btnFight_Click(object sender, EventArgs e)
        {
            gbxDecideAction.Hide();

            gbxFight.Visible = true;
            gbxFight.Location = new Point(95, 60);

            lblText.Font = new Font("Microsoft Sans Serif", 50);
            lblText.Text = "What Combat Technique Were You Thinking Of Using?";
        }
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            gbxFight.Visible = false;
            gbxDecideAction.Visible = true;

            lblText.Font = new Font("Microsoft Sans Serif", 50);
            lblText.Text = "What Are You Going To Do?";
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't run, keep fighting until you die", "NO, YOU CAN'T RUN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            lblCharacterSpec.Text = Player.ToString();
            lblRobomoonSpec.Text = Enemey.ToString();

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
        //
        // End
        //


        //
        // Attack Buttons
        //
        private void btnAttack1_Click(object sender, EventArgs e)
        {
            //
            // Player Fight
            //
            // Attack
            Enemey.Health -= StandardFightThe(Enemey);
            //Health Update
            HealthCheck(Enemey);
            pbrRobomoonHP.Value = Healthbar(Enemey);
            //
            // Robomoon Fight
            //
            Player.Health -= EnemyFightChocie();
            //Health Update
            HealthCheck(Player);
            pbrCharacterHP.Value = Healthbar(Player);
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
            //
            // Player Fight
            //
            // Attack
            Enemey.Health -= DoomFightThe(Enemey);
            //Health Update
            HealthCheck(Enemey);
            pbrRobomoonHP.Value = Healthbar(Enemey);
            //
            // Robomoon Fight
            //
            Player.Health -= EnemyFightChocie();
            //Health Update
            HealthCheck(Player);
            pbrCharacterHP.Value = Healthbar(Player);
            //
            // Go Back
            //
            gbxFight.Visible = false;
            gbxDecideAction.Visible = true;

            lblText.Font = new Font("Microsoft Sans Serif", 50);
            lblText.Text = "What Are You Going To Do?";
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
            //
            // Player Fight
            //
            // Attack
            Enemey.Health -= ARKFightThe(Enemey);
            //Health Update
            HealthCheck(Enemey);
            pbrRobomoonHP.Value = Healthbar(Enemey);
            //
            // Robomoon Fight
            //
            Player.Health -= EnemyFightChocie();
            //Health Update
            HealthCheck(Player);
            pbrCharacterHP.Value = Healthbar(Player);
            //
            // Go Back
            //
            gbxFight.Visible = false;
            gbxDecideAction.Visible = true;

            lblText.Font = new Font("Microsoft Sans Serif", 50);
            lblText.Text = "What Are You Going To Do?";
        }
        //
        // End
        //


        //
        // Methods
        //metoder
        void HealthCheck(Characters characters)
        {
            //
            // Robomoon Health Update
            //
            if (characters == Enemey)
            {
                if (Enemey.Health <= 0)
                {
                    Enemey.Health = 0;
                    Enemey.Apearence = Enemey.DeathApearence;
                    pbxRobomoon.Image = Enemey.Apearence;

                    RobomoonChoose choose = new RobomoonChoose();
                    choose.Show();
                    this.Hide();
                }
            }

            else if (characters == Player)
            {
                if (Player.Health <= 0)
                {
                    Player.Health = 0;
                    Player.Apearence = Player.DeathApearence;
                    pbxCharacter.Image = Player.Apearence;

                    RobomoonChoose choose = new RobomoonChoose();
                    choose.Show();
                    this.Hide();
                }
            }

        }

        int  EnemyFightChocie() 
        {
            Random EnemyAttack = new Random();
            int EnemeyAttackChoice = EnemyAttack.Next(101);
            int EnemeyAttack = -1;
            for (int i = 1; i < 11; i++)
            {
                for (int h = 1 * i; h < 11 * i; h++)
                {
                    if (EnemeyAttackChoice == h)
                    {
                        EnemeyAttack = i;
                    }
                }

                if (EnemeyAttack != i)
                {
                    switch (EnemeyAttack)
                    {
                        case 1:
                            return StandardFightThe(Enemey);
                            break;

                        case 2:
                            return DoomFightThe(Enemey);
                            break;

                        case 3:
                            return -1;
                            break;

                        case 4:
                            return -1;
                            break;

                        case 5:
                            return ARKFightThe(Enemey);
                            break;

                        default:
                            return -1;
                            break;
                    }
                }
            }
            return -1;
        }

        int StandardFightThe(Characters characters)
        {
            if (characters == Enemey)
            {
                if (Enemey.Defence >= Player.AttackDamage)
                {
                    return 1;
                }
                else
                {
                    return Player.AttackDamage - Enemey.Defence;
                }
            }

            else if (characters == Player)
            {
                if (Player.Defence >= Enemey.AttackDamage)
                {
                    return 1;
                }
                else
                {
                    return Enemey.AttackDamage - Player.Defence;
                }
            }
            else
            {
                MessageBox.Show("Something went wrong");
                return -1;
            }
        }

        int DoomFightThe(Characters characters)
        {
            if (characters == Enemey)
            {
                if (Enemey.Defence >= Player.AttackDamage)
                {
                    return 1;
                }
                else
                {
                    return Player.AttackDamage - Enemey.Defence;
                }
            }

            else if (characters == Player)
            {
                if (Player.Defence >= Enemey.AttackDamage)
                {
                    return 1;
                }
                else
                {
                    return Enemey.AttackDamage - Player.Defence;
                }
            }
            else
            {
                MessageBox.Show("Something went wrong");
                return -1;
            }
        }

        int ARKFightThe(Characters characters)
        {
            Random ARK = new Random();
            int ARKChance = ARK.Next(11);

            if (characters == Player)
            {
                if (ARKChance == 1)
                {
                    return 15;
                }

                else
                {
                    return 0;
                }
            }
            else if (characters == Enemey)
            {
                if (ARKChance == 1)
                {
                    return 15;
                }

                else
                {
                    return 0;
                }
            }
            else
            {
                MessageBox.Show("Something went wrong");
                return -1;
            }
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
            if (characters == Enemey)
            {
                CurrentHealth = double.Parse(Enemey.Health.ToString());
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
            else if (characters == Player)
            {
                CurrentHealth = double.Parse(Player.Health.ToString());
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
        //
        // End
        //
    }
}
