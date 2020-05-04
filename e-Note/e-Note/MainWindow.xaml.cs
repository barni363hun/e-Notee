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
        List<Jegyzet> jegyzetek = new List<Jegyzet>();
        List<string> kiírandójegyzetek = new List<string>();
        List<string> grid = new List<string>();

        public MainWindow(string eNodeData)
        {
            InitializeComponent();
            Refresh();
            //Test.Content = eNodeData;
        }
        private void Refresh()
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
        private void Fajlbeolvas(string fájl)
        {
            StreamReader sr = new StreamReader(fájl);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                jegyzetek.Add(new Jegyzet(sr.ReadLine()));
            }
            sr.Close();
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
    }
}
