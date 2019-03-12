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
using System.Windows.Shapes;

namespace ListyFormyLinqyThingy {
    /// <summary>
    /// Interaction logic for frmOther.xaml
    /// </summary>
    public partial class frmOther : Window {
        public frmOther() {
            InitializeComponent();
        }

        private void BtnShowMe_Click(object sender, RoutedEventArgs e) {
            //MainWindow mw = new MainWindow();
            //mw.Show();
            //Universe u = new Universe();
            SuperHero s = (SuperHero)Universe.People[0];
            tbOutput.Text = s.FullName;
            Button b = new Button();
            b.Content = "Something";
            b.Height = 10;
            b.Width = 30;
            grdLayout.Children.Add(b);
        }
    }
}
