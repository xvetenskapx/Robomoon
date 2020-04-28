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

        public FightArena()
        {
            InitializeComponent();
            RobomoonChoose.ActiveForm.Dispose();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //
            // brush propetis
            //
            Graphics g = e.Graphics;
            SolidBrush LightBrush = new SolidBrush(Color.FromArgb(170, 175, 144));
            SolidBrush DarkBrush = new SolidBrush(Color.FromArgb(200, 200, 176));
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
            lblCharacterHP.Text = Player.Health.ToString() + "/" + Player.StartHealth;
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
            btnAttack2.Text = "Doom Slap";
            btnAttack3.Text = "Rocket Man";
            btnAttack4.Text = "Merciful Beating";
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


        //
        // Fixa Buggen med att kunna se det aktuella livet 
        //
        private void btnCharacter_Click(object sender, EventArgs e)
        {
            gbxDecideAction.Hide();

            gbxSpec.Visible = true;
            gbxSpec.Location = new Point(95, 60);

            lblCharacterSpec.Text = Player.CharacterSpec();
            lblRobomoonSpec.Text = Enemey.CharacterSpec();

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
        private void btnAttack1_Click(object sender, EventArgs e)       //Standard
        {
            //
            // Player
            //
            
            Enemey.Health -= StandardFightThe(Enemey);      // Attack
            HealthCheck(Enemey);                            //Health Check
            pbrRobomoonHP.Value = Healthbar(Enemey);        //Health Update
            //
            // Robomoon
            //
            EnemyFightChocie();                             //Enemy Chose Attack
            //
            // Go Back
            //
            DoneAttack();

        }


        private void btnAttack2_Click(object sender, EventArgs e)       //Slap of Doom
        {
            //
            // Player
            //
            Enemey.Health -= DoomFightThe(Enemey);      // Attack
            HealthCheck(Enemey);                        //Health Check
            pbrRobomoonHP.Value = Healthbar(Enemey);    //Health Update
            //
            // Robomoon
            //
            EnemyFightChocie();                         //Enemy Chose Attack
            //
            // Go Back
            //
            DoneAttack();                               //Go back to gbxDecideAction
        }


        private void btnAttack3_Click(object sender, EventArgs e)       //Rocket Man
        {
            //
            // Player
            //
            Enemey.Health -= RocketThe(Enemey);      // Attack
            HealthCheck(Enemey);                        //Health Check
            pbrRobomoonHP.Value = Healthbar(Enemey);    //Health Update
            //
            // Robomoon
            //
            EnemyFightChocie();                         //Enemy Chose Attack
            //
            // Go Back
            //
            DoneAttack();                               //Go back to gbxDecideAction
        }


        private void btnAttack4_Click(object sender, EventArgs e)       //Merciful Beating
        {
            //
            // Player Heal
            //
            Player.Health += MercifulToo(Player);       // Healing
            pbrCharacterHP.Value = Healthbar(Player);       //Health Update
            //
            // Robomoon Fight
            //
            EnemyFightChocie();     //Enemy Chose Attack
            //
            // Go Back
            //
            DoneAttack();
        }


        private void btnAttack5_Click(object sender, EventArgs e)       //ARK
        {
            //
            // Player
            //
            Enemey.Health -= ARKFightThe(Enemey);       // Attack
            HealthCheck(Enemey);                        //Health Check
            pbrRobomoonHP.Value = Healthbar(Enemey);    //Health Update
            //
            // Robomoon
            //
            EnemyFightChocie();                         //Enemy Chose Attack
            //Health Update
            HealthCheck(Player);
            pbrCharacterHP.Value = Healthbar(Player);
            //
            // Go Back
            //
            DoneAttack();                               //Go back to gbxDecideAction
        }
        //
        // End
        //
            

        //
        // Methods
        //
        void EnemyFightChocie()
        #region
        {
            Random EnemyAttack = new Random();
            int EnemeyAttackChoice = EnemyAttack.Next(0, 100);
            int EnemeyAttack = -1;
            int testh = -2;
            int testi = -3;
            for (int i = 0; i <= 4; i++)
            {
                testi = i;
                for (int h = (20 * i); h < 20 + 20 * i; h++)
                {
                    testh = h;
                    if (EnemeyAttackChoice == h)
                    {
                        EnemeyAttack = i;
                        break;
                    }
                }
            #endregion
                if (EnemeyAttack == i)
                {
                    switch (EnemeyAttack)
                    {
                        case 0:     //Standard
                        #region
                            MessageBox.Show("Standard");
                            Player.Health -= StandardFightThe(Player);
                            HealthCheck(Player);                    //Health Check/Update
                            break;
                        #endregion

                        case 1:     //Slap of Doom
                        #region
                            MessageBox.Show("Slap of Doom");
                            Player.Health -= DoomFightThe(Player);
                            HealthCheck(Player);                    //Health Check/Update
                            break;
                        #endregion

                        case 2:     //Rocket Man
                        #region
                            MessageBox.Show("Rocket man");
                            Player.Health -= RocketThe(Player);
                            HealthCheck(Player);                    //Health Check/Update
                            break;
                        #endregion

                        case 3:     //Merciful Beating
                        #region
                            MessageBox.Show("Merciful Beating");
                            Enemey.Health += MercifulToo(Enemey);
                            pbrRobomoonHP.Value = Healthbar(Enemey);                    //Health Update
                            break;
                        #endregion

                        case 4:     //ARK
                        #region
                            MessageBox.Show("ARK");
                            Player.Health -= ARKFightThe(Player);
                            HealthCheck(Player);                    //Health Check/Update
                            break;
                        #endregion

                        default:
                        #region
                            MessageBox.Show("Default   " + "i: " + testi.ToString() + "h: " +  testh.ToString());
                            break;
                        #endregion
                    }
                    break;          //stoppar i-for loopen
                }
            }
            MessageBox.Show("Loop-done   " + "i: " + testi.ToString() + "h: " + testh.ToString());
        }

        int StandardFightThe(Characters characters)     //Done
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

        int DoomFightThe(Characters characters)         //Done For Now Can Be With A CoolDown
        {
            Random Slap = new Random();
            double SlapForce = (double)Slap.Next(2);
            if (SlapForce != 0)
            {
                SlapForce = (double)Slap.Next(50, 151) / 100;
            }

            int SlapDamage;
            if (characters == Enemey)
            {
                SlapDamage = (int)(Player.AttackDamage * SlapForce + 0.5);
                if (Enemey.Defence >= Player.AttackDamage)
                { 
                    return 1 + SlapDamage;
                }
                else
                {
                    return Player.AttackDamage - Enemey.Defence + SlapDamage;
                }
            }

            else if (characters == Player)
            {
                SlapDamage = (int)(Enemey.AttackDamage * SlapForce + 0.5);
                if (Player.Defence >= Enemey.AttackDamage)
                {
                    return 1 + SlapDamage;
                }
                else
                {
                    return Enemey.AttackDamage - Player.Defence + SlapDamage;
                }
            }
            else
            {
                MessageBox.Show("Something went wrong");
                return -1;
            }
        }

        int RocketThe(Characters characters)            //Not even close to done
        {
            Random Rocket = new Random();
            double RocketPower = (double)Rocket.Next(2);
            if (RocketPower != 0)
            {
                RocketPower = (double)Rocket.Next(50, 151) / 100;
            }

            int SlapDamage;
            if (characters == Enemey)
            {
                SlapDamage = (int)(Player.AttackDamage * RocketPower + 0.5);
                if (Enemey.Defence >= Player.AttackDamage)
                {
                    return 1 + SlapDamage;
                }
                else
                {
                    return Player.AttackDamage - Enemey.Defence + SlapDamage;
                }
            }

            else if (characters == Player)
            {
                SlapDamage = (int)(Enemey.AttackDamage * RocketPower + 0.5);
                if (Player.Defence >= Enemey.AttackDamage)
                {
                    return 1 + SlapDamage;
                }
                else
                {
                    return Enemey.AttackDamage - Player.Defence + SlapDamage;
                }
            }
            else
            {
                MessageBox.Show("Something went wrong");
                return -1;
            }
        }
        
        int MercifulToo(Characters characters)          //Done I Belive
        {
            Random mercy = new Random();
            double Life = mercy.Next(0, 11);
            Life /= 10;

            int LifeSave;
            if (characters == Enemey)
            {
                if (Enemey.StartHealth == Enemey.Health)
                {
                    return 0;
                }

                LifeSave = (int)(Enemey.StartHealth * Life + 0.5);

                if (Enemey.Health + LifeSave > Enemey.StartHealth)
                {
                    return (Enemey.StartHealth - Enemey.Health);
                }

                return LifeSave;
            }

            else if (characters == Player)
            {
                if (Player.StartHealth == Player.Health)
                {
                    return 0;
                }

                LifeSave = (int)(Player.StartHealth * Life + 0.5);

                if (Player.Health + LifeSave > Player.StartHealth)
                {
                    return Player.StartHealth - Player.Health;
                }

                return LifeSave;
            }
            
            else
            {
                return 1;
            }
        }

        int ARKFightThe(Characters characters)          //Done
        {
            Random ARK = new Random();
            int ARKChance = ARK.Next(11);
            MessageBox.Show("ARK" + ARKChance.ToString());

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


        //
        // Healthbar do all health check/update and so on
        //
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
                pbrRobomoonHP.Value = Healthbar(Enemey);
                
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
                pbrCharacterHP.Value = Healthbar(Player);
            }

        }


        int Healthbar(Characters characters)
        {
            double playerstarterhealth = double.Parse(Player.StartHealth.ToString());
            double enemystarterhealth = double.Parse(Enemey.StartHealth.ToString());
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
                    lblCharacterHP.Text = CurrentHealth.ToString() + "/" + playerstarterhealth.ToString();
                    return 0;
                }

                lblCharacterHP.Text = CurrentHealth.ToString() + "/" + playerstarterhealth.ToString();
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


        void DoneAttack()
        {
            gbxFight.Visible = false;
            gbxDecideAction.Visible = true;

            lblText.Font = new Font("Microsoft Sans Serif", 50);
            lblText.Text = "What Are You Going To Do?";
        }
        //
        // End
        //
    }
}
