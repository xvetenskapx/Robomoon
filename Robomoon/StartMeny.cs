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
        RobomoonChoose robomoonChoose = new RobomoonChoose();

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

        private void lblstartgame_Click(object sender, EventArgs e)
        {
            robomoonChoose.Show();
            this.Hide();
        }
    }
}
