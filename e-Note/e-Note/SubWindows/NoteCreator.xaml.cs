using e_Note.Classes;
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
using System.Windows.Shapes;

namespace e_Note.SubWindows
{
    /// <summary>
    /// Interaction logic for NoteCreator.xaml
    /// </summary>
    public partial class NoteCreator : Window
    {
        Options options;
        List<Jegyzet> jegyzetek = new List<Jegyzet>();
        public NoteCreator(Options beállítások)
        {
            options = beállítások;
            InitializeComponent();
            List<Jegyzet> testt = options.Fájlbeolvas();
            if (testt.Count>0)
            {
                foreach (var item in testt)
                {
                    L_Cím.Content = item.Cim;
                    foreach (var cimke in item.Címkék)
                    {
                        L_Címkék.Content += cimke;
                    }
                    L_Tartalom.Content = item.Tartalom;
                }
            }
        }

        private void Kész_Click(object sender, RoutedEventArgs e)
        {
            List<Jegyzet> lista = options.Fájlbeolvas();
            //List<Jegyzet> lista = new List<Jegyzet>();
            string[] címkék = Címkék.Text.Split(',');
            Jegyzet felvevendő = new Jegyzet("sima", Cim.Text, Tartalom.Text, címkék);
            //Jegyzet testtt = new Jegyzet("sima", "címe", "tartalma", címkék);
            lista.Add(felvevendő);
            /*foreach (var item in lista)
            {
                L_Cím.Content = item.Cim;
                L_Tartalom.Content = item.Tartalom;
            }*/
            string újfájl = options.Jegyzettömbstringbe(lista); 
            File.WriteAllText(options.path, options.crypto.EncryptStringAES(újfájl.ToString(), options.password));
        }
    }
}
