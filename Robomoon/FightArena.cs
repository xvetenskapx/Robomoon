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
        Characters Player = Characters.PlayableCharacters.ElementAt(Characters.PlayerIndex);
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
            //Ovalerna
            //
            // Yttre Fiende Ovalen
            g.FillEllipse(DarkBrush, 1000, 130, 820, 206);
            // Inre Fiende Ovalen
            g.FillEllipse(LightBrush, 1010, 140, 800, 186);
            // Yttre Spelare Ovalen 
            g.FillEllipse(DarkBrush, 100, 385, 820, 206);
            // Inre Spelare Ovalen
            g.FillEllipse(LightBrush, 110, 395, 800, 186);
        }


        private void FightArena_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Exit Fightarena so it is not in the backgrund
            Application.Exit();
        }


        private void FightArena_Load(object sender, EventArgs e)
        {
            //Load in character's and enemy's face
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

            //Show new groupbox and move it to its place
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
        private void btnCharacter_Click(object sender, EventArgs e)
        {
            gbxDecideAction.Hide();

            //Show new groupbox and move it to its place
            gbxSpec.Visible = true;
            gbxSpec.Location = new Point(95, 60);

            //Show character's and enemey's name, health, etc
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
            Enemey.Health -= StandardFightThe(Enemey);      //Attack
            HealthCheck(Enemey);                            //Health Check
            pbrRobomoonHP.Value = Healthbar(Enemey);        //Health Update
            //
            // Robomoon
            //
            if (Enemey.Health != 0)
            {
                EnemyFightChocie();                             //Enemy Chose Attack and do an health check and update
            }
            //
            // Go Back
            //
            DoneAttack();                                   //Go back to gbxDecideAction

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
            if (Enemey.Health != 0)
            {
                EnemyFightChocie();                             //Enemy Chose Attack and do an health check and update
            }
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
            Enemey.Health -= RocketThe(Enemey);         //Attack
            HealthCheck(Enemey);                        //Health Check
            pbrRobomoonHP.Value = Healthbar(Enemey);    //Health Update
            //
            // Robomoon
            //
            if (Enemey.Health != 0)
            {
                EnemyFightChocie();                             //Enemy Chose Attack and do an health check and update
            }
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
            Player.Health += MercifulToo(Player);           // Healing
            pbrCharacterHP.Value = Healthbar(Player);       //Health Update
            //
            // Robomoon Fight
            //
            if (Enemey.Health != 0)
            {
                EnemyFightChocie();                             //Enemy Chose Attack and do an health check and update
            }
            //
            // Go Back
            //
            DoneAttack();                                   //Go back to gbxDecideAction
        }


        private void btnAttack5_Click(object sender, EventArgs e)       //ARK
        {
            //
            // Player
            //
            Enemey.Health -= ARKFightThe(Enemey);           // Attack
            HealthCheck(Enemey);                            //Health Check
            pbrRobomoonHP.Value = Healthbar(Enemey);        //Health Update
            //
            // Robomoon
            //
            if (Enemey.Health != 0)
            {
                EnemyFightChocie();                             //Enemy Chose Attack and do an health check and update
            }
            //
            // Go Back
            //
            DoneAttack();                                   //Go back to gbxDecideAction
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
            int EnemeyAttackChoice = EnemyAttack.Next(0, 100);          //Randomize a number between 0 and 99. (I know it is not upp to a 100 becuse I want ark to be slighter harder to achive)
            int EnemeyAttack = -1;
            for (int i = 0; i <= 4; i++)                                //loop thats goes four times and after each time the interval increase with 20.
            {

                for (int h = (20 * i); h < 20 + 20 * i; h++)            //loops every number betwwen specifik interval to finde the reigh number.
                {
                    if (EnemeyAttackChoice == h)
                    {
                        EnemeyAttack = i;                               //Robomoons attack decides of between which interval the number is between.
                        break;                                          //Stop the h-loop
                    }
                }
                #endregion
                if (EnemeyAttack == i)
                {
                    switch (EnemeyAttack)
                    {
                        case 0:     //Standard
                            #region
                            //MessageBox.Show("Standard");
                            Player.Health -= StandardFightThe(Player);
                            HealthCheck(Player);                            //Health Check/Update
                            break;
                        #endregion

                        case 1:     //Slap of Doom
                            #region
                            //MessageBox.Show("Slap of Doom");
                            Player.Health -= DoomFightThe(Player);
                            HealthCheck(Player);                            //Health Check/Update
                            break;
                        #endregion

                        case 2:     //Rocket Man
                            #region
                            //MessageBox.Show("Rocket man");
                            Player.Health -= RocketThe(Player);
                            HealthCheck(Player);                            //Health Check/Update
                            break;
                        #endregion

                        case 3:     //Merciful Beating
                            #region
                            //MessageBox.Show("Merciful Beating");
                            Enemey.Health += MercifulToo(Enemey);
                            pbrRobomoonHP.Value = Healthbar(Enemey);        //Health Update
                            break;
                        #endregion

                        case 4:     //ARK
                            #region
                            //MessageBox.Show("ARK");
                            Player.Health -= ARKFightThe(Player);
                            HealthCheck(Player);                            //Health Check/Update
                            break;
                        #endregion

                        default:
                            #region
                            break;
                            #endregion
                    }
                    break;          //stopps the i-for loop
                }
            }
        }

        int StandardFightThe(Characters characters)     //Done
        {
            //The standard fight damage is the diffrece bettwen the attacker's attack and the opposed diffrence
            if (characters == Enemey)                           //Player attack enemy
            {
                if (Enemey.Defence >= Player.AttackDamage)      //If the defence is higher then the attack then the damage is only 1
                {
                    return 1;
                }

                else
                {
                    return Player.AttackDamage - Enemey.Defence;
                }
            }

            else if (characters == Player)                      //Enemy attack player
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
            else                                                //should not be posibal to archive
            {
                MessageBox.Show("Something went wrong with the Characters");
                return -1;
            }
        }

        int DoomFightThe(Characters characters)         //Done
        {
            //The standard fight damage is the diffrece bettwen the attacker's attack and the opposed diffrence.
            //Slap force can be a bounus damage. 50% of the time it is not an bouns. the bounus can be increse and decrese the attack damage.
            //Max bonus 150, min decrese 50

            Random Slap = new Random();
            double SlapForce = (double)Slap.Next(2);
            if (SlapForce != 0)                                                 //Decide if there should be any increase
            {
                SlapForce = (double)Slap.Next(50, 151) / 100;                   //Deicde the power of the increase
            }

            int SlapDamage;
            if (characters == Enemey)
            {
                SlapDamage = (int)(Player.AttackDamage * SlapForce + 0.5);      //Slap damage is the orginal attack damage multiplide by the increse.
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
                MessageBox.Show("Something went wrong with the Characters");
                return -1;
            }
        }

        int RocketThe(Characters characters)            //Done
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
                MessageBox.Show("Something went wrong with the Characters");
                return -1;
            }
        }

        int MercifulToo(Characters characters)          //Done
        {
            Random mercy = new Random();
            double Life = mercy.Next(0, 11);
            Life /= 10;                                 //Health restore can only be tenths

            int LifeSave;
            if (characters == Enemey)
            {
                if (Enemey.StartHealth == Enemey.Health)                    //If Robomoon alreday have full health no additional health will be added
                {
                    return 0;
                }

                LifeSave = (int)(Enemey.StartHealth * Life + 0.5);

                if (Enemey.Health + LifeSave > Enemey.StartHealth)          //If Robomoon health plus the restore health is the same as orginal health only the diffrence will sent back. (Full life afterward)
                {
                    return (Enemey.StartHealth - Enemey.Health);
                }
                else                                                        //Else full restore life will be sent back
                {
                    return LifeSave;
                }
            }

            else if (characters == Player)
            {
                if (Player.StartHealth == Player.Health)                    //If Chatacter alreday have full health no additional health will be added
                {
                    return 0;
                }

                LifeSave = (int)(Player.StartHealth * Life + 0.5);

                if (Player.Health + LifeSave > Player.StartHealth)          //If Character health plus the restore health is the same as orginal health only the diffrence will sent back. (Full life afterward)
                {
                    return Player.StartHealth - Player.Health;
                }
                else                                                        //Else full restore life will be sent back
                {
                    return LifeSave;
                }
            }

            else
            {
                MessageBox.Show("Something went wrong with the Characters");
                return 1;
            }
        }

        int ARKFightThe(Characters characters)          //Done
        {
            Random ARK = new Random();
            int ARKChance = ARK.Next(11);               //it is only a tenths chance to get an succesiful ARK. Bucuse ARK is very powerfull
            //MessageBox.Show("ARK" + ARKChance.ToString());

            if (characters == Player)
            {
                if (ARKChance == 1)
                {
                    return 30;
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
                MessageBox.Show("Something went wrong with the Characters");
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
                if (Enemey.Health <= 0)                                     //If health is or under 0 the game is over.
                {
                    Enemey.Health = 0;
                    Enemey.Apearence = Enemey.DeathApearence;
                    pbxRobomoon.Image = Enemey.Apearence;
                    MessageBox.Show(Enemey.Name + " has been killed", "Robomoon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);        //Tell how have been killed

                    Characters.CreatorNotRun = false;                       //Our Characters has already been created
                    RobomoonChoose choose = new RobomoonChoose();
                    choose.Show();
                    this.Hide();
                }
                pbrRobomoonHP.Value = Healthbar(Enemey);                    //if the Robomoon is not dead a update of the healthbar will run.
            }

            else if (characters == Player)                                  //If health is or under 0 the game is over.
            {
                if (Player.Health <= 0)
                {
                    Player.Health = 0;
                    Player.Apearence = Player.DeathApearence;
                    pbxCharacter.Image = Player.Apearence;
                    MessageBox.Show(Player.Name + " has been killed", "Plyer Killed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);        //Tell how have been killed

                    Characters.CreatorNotRun = false;                       //Our Characters has already been created
                    RobomoonChoose choose = new RobomoonChoose();
                    choose.Show();
                    this.Hide();
                }
                pbrCharacterHP.Value = Healthbar(Player);                   //if the Character is not dead a update of the healthbar will run.
            }

        }


        int Healthbar(Characters characters)
        {
            //copy player starter health to a double and privet for only this code.
            double playerstarterhealth = double.Parse(Player.StartHealth.ToString());
            double enemystarterhealth = double.Parse(Enemey.StartHealth.ToString());
            //Varibales that makes the code a little easier to work with
            double CurrentHealth = -1;
            double PercentageHealth = -1;

            //
            // Robomoon Health Percentage
            //
            if (characters == Enemey)
            {
                CurrentHealth = double.Parse(Enemey.Health.ToString());
                PercentageHealth = ((CurrentHealth / enemystarterhealth) * 100) + 0.5;                          //procentage of the life multiplide by a 100 plus 0.5 to get the right roundnig and to get it to an int.

                if (PercentageHealth <= 0)                                                                      //should not be posibly
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
                PercentageHealth = ((CurrentHealth / playerstarterhealth) * 100) + 0.5;                         //procentage of the life multiplide by a 100 plus 0.5 to get the right roundnig and to get it to an int.

                if (PercentageHealth <= 0)                                                                      //should not be posibly
                {
                    lblCharacterHP.Text = CurrentHealth.ToString() + "/" + playerstarterhealth.ToString();
                    return 0;
                }

                lblCharacterHP.Text = CurrentHealth.ToString() + "/" + playerstarterhealth.ToString();          //Update the health under the the bar
                return (int)PercentageHealth;
            }

            //
            // Back up
            //
            else
            {
                MessageBox.Show("Something wrong with Healthbar characters");
                return -1;
            }

        }


        void DoneAttack()
        {
            //Method to get back after character has made its move.
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
   