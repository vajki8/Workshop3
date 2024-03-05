using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace workshop3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Trooper> troopers;
        ObservableCollection<Trooper> army = new ObservableCollection<Trooper>();
        int osszeg = 0;
        public MainWindow()
        {
            InitializeComponent();

            troopers = new ObservableCollection<Trooper>()
            {
                new Trooper(){Name="Marine",Vitality=8,Speed=5,Cost=5},
                new Trooper(){Name="Pilot",Vitality=7,Speed=3,Cost=10},
                new Trooper(){Name="Infantry",Vitality=6,Speed=8,Cost=10},
                new Trooper(){Name="Sniper",Vitality=2,Speed=1,Cost=8},
                new Trooper(){Name="Engineer",Vitality=4,Speed=4,Cost=6}
            };
            listbox_left.ItemsSource = troopers;
            listbox_right.ItemsSource = army;
        }

        private void CostChange()
        {
            cost.Content = "Army cost:" + osszeg.ToString() + "$";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            army.Add((Trooper)listbox_left.SelectedItem);
            int osszeg = 0;
            foreach (var Trooper in army)
            {
                osszeg+= Trooper.Cost;
            }
            CostChange();
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            army.Remove((Trooper)listbox_right.SelectedItem);
            int osszeg = 0;
            foreach(var Trooper in army)
            {
                osszeg+= Trooper.Cost;
            }
            CostChange();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
