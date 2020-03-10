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
        public StartMeny()
        {
            InitializeComponent();
        }

        private void StartMeny_Load(object sender, EventArgs e)
        {
            //Gör skärmen i fullstorlek
            this.WindowState = FormWindowState.Maximized;

            //Öppnar nästa fönster där valet av Robomoon är
            RobomoonChoose robomoonChoose = new RobomoonChoose();
            robomoonChoose.Show();
        }

        private void MainMenyClosing_Tick(object sender, EventArgs e)
        {
            //Gömmer start menyn. Första formet kan ej stängas ner. Då stängs applicationen ner.
            this.Hide();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            //Glöm inte kanppen
            MessageBox.Show("Glöm inte denna knappen");
        }
    }
}
