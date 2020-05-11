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
    
    public partial class StartMeny : Form
    {
        RobomoonChoose RobomoonChoose = new RobomoonChoose();
        
        // Random to Everyone
        public static Random RandomStat = new Random();

        // Sound effects
        #region
        public static System.Media.SoundPlayer Strong_punch = new System.Media.SoundPlayer(@"Sound Effects\\Strong_Punch-Mike_Koenig-574430706.wav");
        public static System.Media.SoundPlayer Slap = new System.Media.SoundPlayer(@"Sound Effects\\Slap-SoundMaster13-49669815.wav");
        public static System.Media.SoundPlayer Kick = new System.Media.SoundPlayer(@"Sound Effects\\Kick-SoundBible.com-1331196005.wav");
        public static System.Media.SoundPlayer Banana_slap = new System.Media.SoundPlayer(@"Sound Effects\\Banana_Slap-AngryFlash-2001109808.wav");
        public static System.Media.SoundPlayer DUN = new System.Media.SoundPlayer(@"Sound Effects\\DUN DUN DUUUUN Sound Effect (1).wav");
        public static System.Media.SoundPlayer dun = new System.Media.SoundPlayer(@"Sound Effects\\dun_dun_dun-Delsym-719755295.wav");
        public static System.Media.SoundPlayer Yahoo = new System.Media.SoundPlayer(@"Sound Effects\\yahoo.wav");
        public static System.Media.SoundPlayer UpperCut = new System.Media.SoundPlayer(@"Sound Effects\\Upper Cut-SoundBible.com-1272257235.wav");
        #endregion

        public StartMeny()
        {
            InitializeComponent();
            
        }

        private void StartMeny_Load(object sender, EventArgs e)
        {
            //Set Window to full sized
            this.WindowState = FormWindowState.Maximized;
            //Change Background
            this.BackgroundImage = Image.FromFile("Picture\\Other\\MenyBakcground.bmp");
        }

        private void Lblstartgame_Click(object sender, EventArgs e)
        {
            Yahoo.Play();
            RobomoonChoose.Show();
            this.Hide();
        }
    }
}
