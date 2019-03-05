using System;
using System.Collections.Generic;
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

namespace ListyFormyLinqyThingy {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            SuperHero[] sups = new SuperHero[4];
            sups[0] = new SuperHero("mad","mike");
            sups[1] = new SuperHero("mad","mike");
            sups[2] = new SuperHero("mad","mike");
            sups[3] = new SuperHero("mad","mike");
           // sups[4] = new SuperHero("mad","mike");

            List<SuperHero> supd = new List<SuperHero>(5);
            SuperHero s = new SuperHero("Bob","Awesome");
            MessageBox.Show(sups.Length + " | " + supd.Count().ToString());
            
            supd.Add(s);
            supd.Add(s);
            supd.Add(s);
            supd.Add(s);
            supd.Add(s);
            supd.Add(s);
            supd.Add(s);
            supd.Add(s);
            supd.Add(s);
            supd.Add(s);
            supd.Add(s);
            supd.Add(s);
            supd.Add(s);
            supd.Add(s);
            supd.Add(s);
            supd.Add(s);

            MessageBox.Show(sups.Length + " | " + supd.Count().ToString());

            

        }
    }
}
