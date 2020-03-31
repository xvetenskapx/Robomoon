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

        private void FightArena_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            gbxDecideAction.Hide();

            gbxFight.Visible = true;
            gbxFight.Location = new Point(1000, 710);
            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't, keep fighting until someone dies", "NO, YOU CAN'T RUN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
