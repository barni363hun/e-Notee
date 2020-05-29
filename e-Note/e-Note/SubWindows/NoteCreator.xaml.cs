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
        private List<ImageBrush> kép;
        public NoteCreator(Options beállítások)
        {
            options = beállítások;
            InitializeComponent();
            kép = new List<ImageBrush>();
            ImageBrush myimage1 = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Assets/bgphoto.png", UriKind.Absolute)));
            ImageBrush myimage2 = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Assets/Mainbgdark.jpg", UriKind.Absolute)));
            kép.Add(myimage1);
            kép.Add(myimage2);
            //List<Jegyzet> testt = options.Fájlbeolvas();   //a legutolsó jegyzet adatainak kiiratása
            //if (testt.Count>0)
            //{
            //    foreach (var item in testt)
            //    {
            //        L_Cím.Content = item.Cim;
            //        foreach (var cimke in item.Címkék)
            //        {
            //            L_Címkék.Content += cimke;
            //        }
            //        L_Tartalom.Content = item.Tartalom;
            //    }
            //}
            Refresh();
        }

        private void Refresh()
        {
            Notecreator.Title = options.language.Content.Notecreator_Title;
            L_Cím.Content = options.language.Content.Notecreator_Cim;
            L_Tartalom.Content = options.language.Content.Notecreator_Tartalom;
            L_Címkék.Content = options.language.Content.Notecreator_Cimke;
            Kész.Content = options.language.Content.Notecreator_Button;

            if (options.DarkMode)
            {


                //dark mode

                
                Kész.Background = new SolidColorBrush(Color.FromArgb(255, 38, 38, 38));
                Kész.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                Kész.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                háttér.Background = kép[1];
                L_Cím.Foreground = Brushes.White;
                L_Tartalom.Foreground = Brushes.White;
                L_Címkék.Foreground = Brushes.White;
            }
            else
            {
                //light mode

               
                Kész.Background = new SolidColorBrush(Color.FromArgb(255, 201, 201, 201));
                Kész.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                Kész.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                háttér.Background = kép[0];
                L_Cím.Foreground = Brushes.Black;
                L_Tartalom.Foreground = Brushes.Black;
                L_Címkék.Foreground = Brushes.Black;
            }
        }

        private void Kész_Click(object sender, RoutedEventArgs e)
        {
            string[] címkék = Címkék.Text.Split(',');
            Jegyzet felvevendő = new Jegyzet("sima", Cim.Text, Tartalom.Text, címkék);
            options.JegyzetHozzáadásAFájlhoz(felvevendő);
            Close();
        }

        
    }
}
