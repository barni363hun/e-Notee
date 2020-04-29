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
        List<string> adatok = new List<string>();

        public MainWindow(string eNodeData)
        {
            InitializeComponent();
           
            //Test.Content = eNodeData;
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




        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)
            {
                Jegyzet j = new Jegyzet();
                if (j.AlmaCimke==Kereso.Text)
                {
                    adatok.Add(j.Cim + j.Tartalom + j.Cimke);
                    Lista.Items.Refresh();
                }
            }
        }

        private void View_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ()
            {
                
            }
            
        }
    }
}
