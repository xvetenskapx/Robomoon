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
    public partial class RobomoonChoose : Form
    {
        public RobomoonChoose()
        {
            InitializeComponent();
            Robomoons r = new Robomoons();            
            r.health = 100;
            r.name = "Stefan";

            Robomoons r1 = new Robomoons();
            r1.health = 9001;

            MessageBox.Show(r.ToString());
            MessageBox.Show(r1.ToString());

            

            //Robomoons[] minRoboms = new Robomoons[100];

            //List<Robomoons> minRobmonsLista = new List<Robomoons>();

            //minRobmonsLista.Add(r);

            //minRobmonsLista.Add(new Robomoons());
            //MessageBox.Show(minRobmonsLista.ElementAt(0).ToString());



        }
    }
}
