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
            //Ovals
            //
            // Outer Enemy ovals
            g.FillEllipse(DarkBrush, 1000, 130, 820, 206);
            // Inner Enemy ovals
            g.FillEllipse(LightBrush, 1010, 140, 800, 186);
            // Outer Player ovals 
            g.FillEllipse(DarkBrush, 100, 385, 820, 206);
            // Inner Enemy ovals
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
            PbxCharacter.Image = Player.Apearence;
            PbxRobomoon.Image = Enemey.Apearence;

            //
            // Character
            //
            LblCharacterName.Text = Player.Name;
            PbrCharacterHP.Value = Healthbar(Player);
            LblCharacterHP.Text = Player.Health.ToString() + "/" + Player.StartHealth;
            //
            // Robomoon
            //
            LblRobomoonNamn.Text = Enemey.Name;
            PbrRobomoonHP.Value = Healthbar(Enemey);
            //
            // Text
            //
            LblText.Font = new Font("Microsoft Sans Serif", 50);
            LblText.Text = "What Are You Going To Do?";
            //
            // FightButtons Name
            //
            BtnAttack1.Text = "Standard";
            BtnAttack2.Text = "Doom Slap";
            BtnAttack3.Text = "Rocket Man";
            BtnAttack4.Text = "Merciful Beating";
            BtnAttack5.Text = "ARK";
        }


        //
        // Group Box Decide Action
        //
        private void BtnFight_Click(object sender, EventArgs e)
        {
            GbxDecideAction.Hide();

            //Show new groupbox and move it to its place
            GbxFight.Visible = true;
            GbxFight.Location = new Point(95, 60);

            LblText.Font = new Font("Microsoft Sans Serif", 50);
            LblText.Text = "What Combat Technique Were You Thinking Of Using?";
        }
        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            GbxFight.Visible = false;
            GbxDecideAction.Visible = true;

            LblText.Font = new Font("Microsoft Sans Serif", 50);
            LblText.Text = "What Are You Going To Do?";
        }
        private void BtnCharacter_Click(object sender, EventArgs e)
        {
            GbxDecideAction.Hide();

            //Show new groupbox and move it to its place
            GbxSpec.Visible = true;
            GbxSpec.Location = new Point(95, 60);

            //Show character's and enemey's name, health, etc
            LblCharacterSpec.Text = Player.CharacterSpec();
            LblRobomoonSpec.Text = Enemey.CharacterSpec();

            LblText.Font = new Font("Microsoft Sans Serif", 50);
            LblText.Text = "Here Is Your And His Specs";
        }
        private void BtnGoBackSpecs_Click(object sender, EventArgs e)
        {
            GbxSpec.Visible = false;
            GbxDecideAction.Visible = true;

            LblText.Font = new Font("Microsoft Sans Serif", 50);
            LblText.Text = "What Are You Going To Do?";
        }
        //
        // End
        //


        //
        // Attack Buttons
        //
        //Standard
        private void BtnAttack1_Click(object sender, EventArgs e)       
        {
            //
            // Player
            //
            //Attack
            StartMeny.Strong_punch.Play();
            Enemey.Health -= StandardFightThe(Enemey);
            //Health Check
            HealthCheck(Enemey);
            //Health Update
            PbrRobomoonHP.Value = Healthbar(Enemey);
            //
            // Robomoons Action
            //
            GbxActions.Enabled = false;
            TmrEnemy.Start();
            //
            // Go Back
            //
            //Go back to GbxDecideAction
            DoneAttack();                                   

        }

        //Slap of Doom
        private void BtnAttack2_Click(object sender, EventArgs e)       
        {
            //
            // Player
            //
            // Attack
            StartMeny.Slap.Play();
            Enemey.Health -= DoomFightThe(Enemey);
            //Health Check
            HealthCheck(Enemey);
            //Health Update
            PbrRobomoonHP.Value = Healthbar(Enemey);
            //
            // Robomoons Action
            //
            GbxActions.Enabled = false;
            TmrEnemy.Start();
            //
            // Go Back
            //
            //Go back to GbxDecideAction
            DoneAttack();                               
        }

        //Rocket Man
        private void btnAttack3_Click(object sender, EventArgs e)       
        {
            //
            // Player
            //
            //Attack
            StartMeny.Kick.Play();
            Enemey.Health -= RocketThe(Enemey);
            //Health Check
            HealthCheck(Enemey);
            //Health Update
            PbrRobomoonHP.Value = Healthbar(Enemey);
            //
            // Robomoons Action
            //
            GbxActions.Enabled = false;
            TmrEnemy.Start();
            //
            // Go Back
            //
            //Go back to GbxDecideAction
            DoneAttack();                               
        }

        //Merciful Beating
        private void BtnAttack4_Click(object sender, EventArgs e)       
        {
            //
            // Player Heal
            //
            // Healing
            StartMeny.Banana_slap.Play();
            Player.Health += MercifulToo(Player);
            //Health Update
            PbrCharacterHP.Value = Healthbar(Player);
            //
            // Robomoons Action
            //
            GbxActions.Enabled = false;
            TmrEnemy.Start();
            //
            // Go Back
            //
            //Go back to GbxDecideAction
            DoneAttack();                                   
        }

        //ARK
        private void BtnAttack5_Click(object sender, EventArgs e)       
        {
            //
            // Player
            //
            // Attack
            //if it is a successfull ark then there are two sound effects
            if (ARKFightThe(Enemey) == 30)
            {
                StartMeny.UpperCut.Play();
                Enemey.Health -= 30;
            }
            else
            {
                StartMeny.Banana_slap.Play();
                Enemey.Health -= 0;
            }
            //Health Check
            HealthCheck(Enemey);
            //Health Update
            PbrRobomoonHP.Value = Healthbar(Enemey);
            //
            // Robomoons Action
            //
            GbxActions.Enabled = false;
            TmrEnemy.Start();
            //
            // Go Back
            //
            //Go back to gbxDecideAction
            DoneAttack();                                   
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
            //Randomize a number between 0 and 99. (I know it is not upp to a 100)
            int EnemeyAttackChoice = StartMeny.RandomStat.Next(0, 100);          
            int EnemeyAttack = -1;
            //loop thats goes four times and after each time the interval increase with 20.
            for (int i = 0; i <= 4; i++)                                
            {
                //loops every number betwwen specifik interval to finde the reigh number.
                for (int h = (20 * i); h < 20 + 20 * i; h++)            
                {
                    if (EnemeyAttackChoice == h)
                    {
                        //Robomoons attack decides of between which interval the number is between.
                        EnemeyAttack = i;
                        //Stop the h-loop
                        break;                                          
                    }
                }
                #endregion
                if (EnemeyAttack == i)
                {
                    switch (EnemeyAttack)
                    {
                        //Standard
                        case 0:
                            #region
                            //MessageBox.Show("Standard");
                            StartMeny.Strong_punch.Play();
                            Player.Health -= StandardFightThe(Player);
                            //Health Check/Update
                            HealthCheck(Player);                            
                            break;
                        #endregion

                        //Slap of Doom
                        case 1:
                            #region
                            //MessageBox.Show("Slap of Doom");
                            StartMeny.Slap.Play();
                            Player.Health -= DoomFightThe(Player);
                            //Health Check/Update
                            HealthCheck(Player);                            
                            break;
                        #endregion

                        //Rocket Man
                        case 2:
                            #region
                            StartMeny.Kick.Play();
                            //MessageBox.Show("Rocket man");
                            Player.Health -= RocketThe(Player);
                            //Health Check/Update
                            HealthCheck(Player);                            
                            break;
                        #endregion

                        //Merciful Beating
                        case 3:
                            #region
                            //MessageBox.Show("Merciful Beating");
                            StartMeny.Banana_slap.Play();
                            Enemey.Health += MercifulToo(Enemey);
                            //Health Update
                            PbrRobomoonHP.Value = Healthbar(Enemey);        
                            break;
                        #endregion

                        //ARK
                        case 4:
                            #region
                            //MessageBox.Show("ARK");
                            //if it is a successfull ark then there are two sound effects
                            if (ARKFightThe(Player) == 30)
                            {
                                StartMeny.UpperCut.Play();
                                Player.Health -= 30;
                            }
                            else
                            {
                                StartMeny.Banana_slap.Play();
                                Player.Health -= 0;
                            }
                            
                            //Health Check/Update
                            HealthCheck(Player);                            
                            break;
                        #endregion

                        default:
                            #region
                            break;
                            #endregion
                    }
                    //stopps the i-for loop
                    break;          
                }
            }
        }

        int StandardFightThe(Characters characters)
        {
            //The standard fight damage is the diffrece bettwen the attacker's attack and the opposed diffrence
            //Player attack enemy
            if (characters == Enemey)                           
            {
                //If the defence is higher then the attack then the damage is only 1
                if (Enemey.Defence >= Player.AttackDamage)      
                {
                    return 1;
                }

                else
                {
                    return Player.AttackDamage - Enemey.Defence;
                }
            }

            //Enemy attack player
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

            //should not be posibal to archive
            else
            {
                MessageBox.Show("Something went wrong with the Characters");
                return -1;
            }
        }

        int DoomFightThe(Characters characters)
        {
            //The standard fight damage is the diffrece bettwen the attacker's attack and the opposed diffrence.
            //Slap force can be a bounus damage. 50% of the time it is not an bouns. the bounus can be increse and decrese the attack damage.
            //Max bonus 150, min decrese 50

            double SlapForce = (double)StartMeny.RandomStat.Next(2);
            //Decide if there should be any change
            if (SlapForce != 0)                                                 
            {
                //Deicde the power of the change
                SlapForce = (double)StartMeny.RandomStat.Next(50, 151) / 100;                   
            }

            int SlapDamage;
            if (characters == Enemey)
            {
                //Slap damage is the orginal attack damage multiplide by the change.
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
                MessageBox.Show("Something went wrong with the Characters");
                return -1;
            }
        }

        int RocketThe(Characters characters)
        {
            //the same as Slap of Doom
            double RocketPower = (double)StartMeny.RandomStat.Next(2);
            if (RocketPower != 0)
            {
                RocketPower = (double)StartMeny.RandomStat.Next(50, 151) / 100;
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

        int MercifulToo(Characters characters)
        {
            double Life = StartMeny.RandomStat.Next(0, 11);
            //Health restore can only be in tenths           
            Life /= 10;                                

            int LifeSave;
            if (characters == Enemey)
            {
                //If Robomoon alreday have full health no additional health will be added
                if (Enemey.StartHealth == Enemey.Health)                    
                {
                    return 0;
                }

                LifeSave = (int)(Enemey.StartHealth * Life + 0.5);

                //If Robomoon health plus the restore health is the same as orginal health only the diffrence will sent back. (Full life afterward)
                if (Enemey.Health + LifeSave > Enemey.StartHealth)          
                {
                    return (Enemey.StartHealth - Enemey.Health);
                }

                //Else full restore life will be sent back
                else
                {
                    return LifeSave;
                }
            }

            else if (characters == Player)
            {
                //If Chatacter alreday have full health no additional health will be added
                if (Player.StartHealth == Player.Health)                    
                {
                    return 0;
                }

                LifeSave = (int)(Player.StartHealth * Life + 0.5);

                //If Character health plus the restore health is the same as orginal health only the diffrence will sent back. (Full life afterward)
                if (Player.Health + LifeSave > Player.StartHealth)          
                {
                    return Player.StartHealth - Player.Health;
                }

                //Else full restore life will be sent back
                else
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

        int ARKFightThe(Characters characters) 
        {
            //it is only a tenths chance to get an succesiful ARK. Becuase ARK is very powerfull
            int ARKChance = StartMeny.RandomStat.Next(11);               
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
                    return 30;
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
                //If health is or under 0 the game is over.
                if (Enemey.Health <= 0)                                     
                {
                    Enemey.Health = 0;
                    PbrRobomoonHP.Value = 0;
                    Enemey.Apearence = Enemey.DeathApearence;
                    PbxRobomoon.Image = Enemey.Apearence;

                    GbxActions.Enabled = false;
                    TmrDeath.Start();
                }
                //if the Robomoon is not dead a update of the healthbar will run.
                PbrRobomoonHP.Value = Healthbar(Enemey);                    
            }

            //If health is or under 0 the game is over.
            else if (characters == Player)                                  
            {
                if (Player.Health <= 0)
                {
                    Player.Health = 0;
                    PbrCharacterHP.Value = 0;
                    Player.Apearence = Player.DeathApearence;
                    PbxCharacter.Image = Player.Apearence;

                    GbxActions.Enabled = false;
                    TmrDeath.Start();
                }
                //if the Character is not dead a update of the healthbar will run.
                PbrCharacterHP.Value = Healthbar(Player);                   
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

                //procentage of the life multiplide by a 100 plus 0.5 to get the right roundnig and to get it to an int.
                PercentageHealth = ((CurrentHealth / enemystarterhealth) * 100) + 0.5;

                //should not be posibly
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
                //procentage of the life multiplide by a 100 plus 0.5 to get the right roundnig and to get it to an int.
                PercentageHealth = ((CurrentHealth / playerstarterhealth) * 100) + 0.5;

                //should not be posibly
                if (PercentageHealth <= 0)                                                                      
                {
                    LblCharacterHP.Text = CurrentHealth.ToString() + "/" + playerstarterhealth.ToString();
                    return 0;
                }

                //Update the health under the the bar
                LblCharacterHP.Text = CurrentHealth.ToString() + "/" + playerstarterhealth.ToString();          
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
            GbxFight.Visible = false;
            GbxDecideAction.Visible = true;

            LblText.Font = new Font("Microsoft Sans Serif", 50);
            LblText.Text = "What Are You Going To Do?";
        }

        //Stops so the players move has time too execute
        private void TmrEnemy_Tick(object sender, EventArgs e)
        {
            if (Enemey.Health != 0)
            {
                TmrEnemy.Stop();
                //Enemy Chose Attack and do an health check and update
                EnemyFightChocie();
            }

            //Enable player to make next move.
            GbxActions.Enabled = true;
            TmrEnemy.Stop();
        }

        private void TmrDeath_Tick(object sender, EventArgs e)
        {
            if (Enemey.Health == 0)
            {
                //Stop Timer
                TmrDeath.Stop();

                //Tell how have been killed
                StartMeny.DUN.Play();
                MessageBox.Show(Enemey.Name + " has been killed", "Robomoon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Our Characters has already been created
                Characters.CreatorNotRun = false;
                RobomoonChoose choose = new RobomoonChoose();
                choose.Show();
                this.Hide();


            }
            else if(Player.Health == 0)
            {
                //Stop Timer
                TmrDeath.Stop();

                //Tell how have been killed
                StartMeny.dun.Play();
                MessageBox.Show(Player.Name + " has been killed", "Plyer Killed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Our Characters has already been created
                Characters.CreatorNotRun = false;
                RobomoonChoose choose = new RobomoonChoose();
                choose.Show();
                this.Hide();



            }
        }
        //
        // End
        //
    }
}
   