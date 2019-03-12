using System;
using System.Collections;
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

            int[] arr = { 1, 2, 3, 4, 5, 6, 6, 7, 41, 8, 52, 5869, 5674, 4 }; //new int[8];
            ArrayList alst = new ArrayList();
            alst.Add(1);
            alst.Add(2);
            alst.Add(5);
            alst.Add(654);
            alst.Add(541);
            alst.Add("Hello");
            alst.Add(new Citizen());
            alst.Add(new Button());

            List<int> ilst = new List<int>();
            ilst.Add(1);
            ilst.Add(2);
            ilst.Add(5);
            ilst.Add(654);
            ilst.Add(541);

            //int sum = 0;
            //for (int i = 0; i < alst.Count; i++) {
            //    sum += ilst[i];
            //}
            //MessageBox.Show(sum.ToString());

            SuperHero[] sups = new SuperHero[4];
            sups[0] = new SuperHero("mad","mike");
            sups[1] = new SuperHero("mad","mike");
            sups[2] = new SuperHero("mad","mike");
            sups[3] = new SuperHero("mad","mike");
           // sups[4] = new SuperHero("mad","mike");

            List<SuperHero> supd = new List<SuperHero>(5);
            SuperHero s = new SuperHero("Bob","Awesome");
            //MessageBox.Show(sups.Length + " | " + supd.Count().ToString());
            
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

            //MessageBox.Show(sups.Length + " | " + supd.Count().ToString());

        }

        private void BtnClickMe_Click(object sender, RoutedEventArgs e) {

            TextBlock tb = new TextBlock();
            tb.Text = "Some really long texty thingy that makes us wonder what we are doing.";
            tb.TextWrapping = TextWrapping.Wrap;
            tb.TextAlignment = TextAlignment.Center;
            btnOtherButton.Content = tb;

        }

        private void BtnOtherButton_Click(object sender, RoutedEventArgs e) {
            List<Citizen> detz = GetCitizens();
            int[] arr = { 1, 2, -3, 4, 5, 6, 6, 7, 41, 8, 52, 5869, 5674, 4 }; //new int[8];

            //MessageBox.Show(detz.Count().ToString());
            //MessageBox.Show(String.Format("Max: {0} Min: {1} Youngest: {2} Last: {3} ???: {4}"
            //    , arr.Max()
            //    , arr.Min(x => x)
            //    , detz.Min(c => c.Age)
            //    , detz.Max(y => y.FirstName)
            //    , detz.Max()
            //    ));

            
            //var answers = arr.Where(i => i % 2 == 1);
            var answers = detz.Where(u => u.FirstName[0] > 'C' && u.FirstName[0] < 'P');
            string ans = "";
            foreach (var item in answers) {
                ans += item + ",";
            }
            MessageBox.Show(ans);

            //MessageBox.Show(String.Format("{0}",
            //        arr.Where(i => i % 6 == 3)
            //    ));


        }

        private List<Citizen> GetCitizens() {
            List<Citizen> citz = new List<Citizen>();
            citz.Add(new Citizen() { FirstName = "Alexis", MiddleName = "Raphael", LastName = "Stafford", DateOfBirth =     new DateTime(1938,03, 27 ) });
            citz.Add(new Citizen() { FirstName = "Gage", MiddleName = "Xanthus", LastName = "Knight", DateOfBirth =         new DateTime(1967,11, 06 ) });
            citz.Add(new Citizen() { FirstName = "Giacomo", MiddleName = "Morgan", LastName = "Robbins", DateOfBirth =      new DateTime(1971,03, 14 ) });
            citz.Add(new Citizen() { FirstName = "Linus", MiddleName = "Sylvester", LastName = "Cochran", DateOfBirth =     new DateTime(1935,09, 19 ) });
            citz.Add(new Citizen() { FirstName = "Dustin", MiddleName = "Hasad", LastName = "Good", DateOfBirth =           new DateTime(1992,07, 09 ) });
            citz.Add(new Citizen() { FirstName = "Vernon", MiddleName = "Gage", LastName = "Peck", DateOfBirth =            new DateTime(2017,11, 05 ) });
            citz.Add(new Citizen() { FirstName = "Amanda", MiddleName = "Alexa", LastName = "Sparks", DateOfBirth =         new DateTime(1992,06, 11 ) });
            citz.Add(new Citizen() { FirstName = "Karyn", MiddleName = "George", LastName = "Wilcox", DateOfBirth =         new DateTime(1918,12, 27 ) });
            citz.Add(new Citizen() { FirstName = "Judah", MiddleName = "Daphne", LastName = "Ryan", DateOfBirth =           new DateTime(1921,12, 05 ) });
            citz.Add(new Citizen() { FirstName = "Eaton", MiddleName = "Francis", LastName = "Barker", DateOfBirth =        new DateTime(1929,05, 05 ) });
            citz.Add(new Citizen() { FirstName = "Quincy", MiddleName = "Cody", LastName = "Thornton", DateOfBirth =        new DateTime(1921,07, 17 ) });
            citz.Add(new Citizen() { FirstName = "Ignatius", MiddleName = "April", LastName = "Mckee", DateOfBirth =        new DateTime(1947,03, 07 ) });
            citz.Add(new Citizen() { FirstName = "Colby", MiddleName = "Leila", LastName = "Goff", DateOfBirth =            new DateTime(1986,01, 13 ) });
            return citz;
        }

        private void BtnShowSomething_Click(object sender, RoutedEventArgs e) {
            //Citizen s = new Citizen();
            //MainWindow mw = new MainWindow();
            //mw.Show();
            SuperHero s = new SuperHero("Fred", "Magic");
            frmOther fo = new frmOther();
            //Universe u = new Universe();
            Universe.People.Add(s);
            Universe.People.Add(new Villian() { FirstName = "Nah" });
            fo.ShowDialog();
        }

        private void BtnShowSomethingElse_Click(object sender, RoutedEventArgs e) {
            Citizen c = new Citizen();
            Citizen.MagicNumber = 2;
        }
    }
}
