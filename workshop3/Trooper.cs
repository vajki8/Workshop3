using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace workshop3
{
    public class Trooper : INotifyPropertyChanged
    {
        private string name;
        private int speed;
        private int vitality;
        private int cost;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; OnPropertyChanged(); }
        }
        public int Vitality 
        { 
            get { return vitality; } 
            set { vitality = value; OnPropertyChanged(); }
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if( handler != null ) { handler(this, new PropertyChangedEventArgs(propertyName));}
        }    
    }
}
