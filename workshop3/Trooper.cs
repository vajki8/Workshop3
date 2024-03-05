using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop3
{
    public class Trooper
    {
        private string name;
        private int speed;
        private int vitality;
        private int cost;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Vitality 
        { 
            get { return vitality; } 
            set { vitality = value; }
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

    }
}
