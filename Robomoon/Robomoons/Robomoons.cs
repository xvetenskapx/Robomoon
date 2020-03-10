using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robomoon
{
    class Robomoons
    {
        //Robomoons name
        public string name = "test";
        public int health;
        public int ATTDMG = 20;
        public int Shild = 30;

        public override string ToString()
        {
            return this.name + " Health:" + this.health;
        }

    }
}
