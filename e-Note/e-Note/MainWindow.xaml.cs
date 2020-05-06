using e_Note.Classes;
using e_Note.Classes.Leanguages;
using e_Note.SubWindows;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace e_Note
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Options options;
        List<Jegyzet> jegyzetek = new List<Jegyzet>();
        List<string> kiírandójegyzetek = new List<string>();
        List<string> grid = new List<string>();

        public MainWindow(Options beállítások)
        {
            options = beállítások;
            InitializeComponent();
            Refresh();
            //Test.Content = eNodeData;
        }
        private void Refresh()
        {
            if (options.DarkMode)
            {
                SwitchColor.Background = new SolidColorBrush(Color.FromArgb(255, 128, 0, 0));
            }
            else
            {
                SwitchColor.Background = new SolidColorBrush(Color.FromArgb(255, 210, 105, 30));
            }
        }

        private void Search()
        {
            foreach (var jegyzetitem in jegyzetek)
            {
                foreach (var kji in kiírandójegyzetek) //kji = kiírandójegyzetitem
                {
                    if (kji == jegyzetitem.Cim)
                    {
                        if (View.SelectedItem.ToString() == "Grid")
                        {
                            //jegyzetek kiírása gridekként dinamikusan (3/sor)
                        }
                        else
                        {
                            //jegyzetek kiírása gridekként dinamikusan (1/sor)
                        }
                    }
                }
            }
        }
        public List<Jegyzet> Jegyzethozzáfűz(string fájl, List<Jegyzet> jegyzetekek)
        {
            StreamReader sr = new StreamReader(fájl);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                jegyzetekek.Add(new Jegyzet(sr.ReadLine()));
            }
            sr.Close();
            return jegyzetekek;
        }
        private void Kereso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Kereso.Text == "")
                {
                    kiírandójegyzetek.Clear();
                }
                else
                {
                    foreach (Jegyzet jegyzetitem in jegyzetek)
                    {
                        foreach (var cimke in jegyzetitem.Címkék)
                        {
                            string keresendő = Kereso.Text;
                            if (cimke == keresendő)
                            {
                                kiírandójegyzetek.Add(jegyzetitem.Cim);
                            }
                        }
                    }
                }
            }
            Refresh();
        }
        private void View_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
        private void Language_Loaded(object sender, RoutedEventArgs e)
        {
            Language.SelectedItem = EN;
        }
        private void View_Loaded(object sender, RoutedEventArgs e)
        {
            View.SelectedItem = Grid;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            options.DarkMode = !options.DarkMode;
            Refresh();
        }
        private void AddNote_Click(object sender, RoutedEventArgs e)
        {
            NoteCreator NoteCreatorWindow = new NoteCreator(options);
            NoteCreatorWindow.Show();
        }
    }
}
