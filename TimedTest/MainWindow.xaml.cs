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


namespace TimedTest
    {
    /// <summary>
    /// This is a timed test with the following spec:
    /// The app must give 3 boxes that allow you to produce a list of countries, with cities and people in each city
    /// Predefined data generation does not count in the development time!
    /// 
    /// </summary>
    public partial class MainWindow : Window
        {
        public List<Person> people = new List<Person>();
        public List<country> Countries = new List<country>();

        public MainWindow()
            {
            InitializeComponent();
            Dictionary<string, List<string>> citiesData = new Dictionary<string, List<string>>() { { "France", new List<String>() { "Paris", "Lyon" } },
                                                                                                   { "England", new List<string>() {"Birmingham", "Bristol" } },
                                                                                                   {"Spain", new List<string>() {"Madrid" } },
                                                                                                    {"Germany", new List<string>() {"Dusseldorf","Berlin" } } };

            foreach (string c in new List<string>() { "France", "England", "Spain", "Germany" })
                {
                Countries.Add(new country(c, citiesData[c].Select(x => new City(x)).ToList())); //NO Checking of keys is happening here - I know! and yes, I cheated with the lambda :P
                }


            foreach (country c in Countries)
                {
                Results.Text += $"{c.Name}\n"; //could have abstracted even this :P
                foreach (City city in c.Cities)
                    {
                    Results.Text += $"\t\t{city.Name}\n";
                    }
                }
            }
        }
    }


     
