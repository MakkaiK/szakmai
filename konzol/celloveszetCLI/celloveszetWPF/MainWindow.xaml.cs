using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace celloveszetWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<cellovo> lovesek = new List<cellovo>();

        internal class cellovo
        {
            public string nev { get; private set; }
            public int elsoloves { get; private set; }
            public int masodikloves { get; private set; }
            public int harmadikloves { get; private set; }
            public int negyedikloves { get; private set; }
            public cellovo(string sor)
            {
                string[] adat = sor.Split(";");
                nev = adat[0];
                elsoloves = int.Parse(adat[1]);
                masodikloves = int.Parse(adat[2]);
                harmadikloves = int.Parse(adat[3]);
                negyedikloves = int.Parse(adat[4]);
            }
        }
        public MainWindow()
        {
            InitializeComponent();

            foreach (var sor in File.ReadLines("lovesek.csv"))
            {
                lovesek.Add(new cellovo(sor));
            }

            datagrid.ItemsSource= lovesek;
        }

        private void Hozzaad(object sender, RoutedEventArgs e)
        {
            if (int.Parse(elsoloves.Text) >= 0 && int.Parse(elsoloves.Text) <= 99 && int.Parse(masodikloves.Text) >= 0 && int.Parse(masodikloves.Text) <= 99 && int.Parse(harmadikloves.Text) >= 0 && int.Parse(harmadikloves.Text) <= 99 && int.Parse(negyedikloves.Text) >= 0 && int.Parse(negyedikloves.Text) <= 99)
            {
                lovesek.Add(new cellovo($"{nev.Text};{elsoloves.Text};{masodikloves.Text};{harmadikloves.Text};{negyedikloves.Text}"));
                datagrid.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Nem megfelelő értékek");
            }
        }

        private void Mentes(object sender, RoutedEventArgs e)
        {
            string adat = "";
            foreach (var cellovo in lovesek)
            {
                adat += $"{cellovo.nev};{cellovo.elsoloves};{cellovo.masodikloves};{cellovo.harmadikloves};{cellovo.negyedikloves}\n";
            }
            File.WriteAllText("cellovo2" , adat);
            MessageBox.Show("A mentés sikeresen megtörtént!");
        }
    }
}