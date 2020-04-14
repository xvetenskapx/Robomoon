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


        private void btnFight_Click(object sender, EventArgs e)
        {
            gbxDecideAction.Hide();

            gbxFight.Visible = true;
            gbxFight.Location = new Point(25, 38);
            
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't run, keep fighting until you die", "NO, YOU CAN'T RUN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void btnGoBack_Click(object sender, EventArgs e)
        {
            gbxFight.Visible = false;
            gbxDecideAction.Visible = true;
        }

        private void FightArena_Load(object sender, EventArgs e)
        {

        }
    }
}
