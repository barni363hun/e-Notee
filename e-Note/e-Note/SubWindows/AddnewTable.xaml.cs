using e_Note.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace e_Note
{
    /// <summary>
    /// Interaction logic for AddnewTable.xaml
    /// </summary>
    public partial class AddnewTable : Window
    {
        Options options;
        List<Jegyzet> jegyzetek = new List<Jegyzet>();
        private List<ImageBrush> kép;
        public AddnewTable(Options beallitas)
        {
            options = beallitas;
            InitializeComponent();
            kép = new List<ImageBrush>();
            ImageBrush myimage1 = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Assets/bgphoto.png", UriKind.Absolute)));
            ImageBrush myimage2 = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Assets/Mainbgdark.jpg", UriKind.Absolute)));
            kép.Add(myimage1);
            kép.Add(myimage2);
            Refresh();
        }

        private void Refresh()
        {
            Newtable.Title = options.language.Content.AddnewTable_Title;
            L_Cím.Content = options.language.Content.AddnewTable_Cim;
            L_Tartalom.Content = options.language.Content.AddnewTable_Tartalom;
            L_Címkék.Content = options.language.Content.AddnewTable_Cimke;
            Mentés.Content = options.language.Content.AddnewTable_Mentes;

            if (options.DarkMode)
            {


                //dark mode


                Mentés.Background = new SolidColorBrush(Color.FromArgb(255, 38, 38, 38));
                Mentés.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                Mentés.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                háttér.Background = kép[1];
                L_Cím.Foreground = Brushes.White;
                L_Tartalom.Foreground = Brushes.White;
                L_Címkék.Foreground = Brushes.White;

            }
            else
            {
                //light mode


                Mentés.Background = new SolidColorBrush(Color.FromArgb(255, 201, 201, 201));
                Mentés.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                Mentés.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                háttér.Background = kép[0];
                L_Cím.Foreground = Brushes.Black;
                L_Tartalom.Foreground = Brushes.Black;
                L_Címkék.Foreground = Brushes.Black;
            }
        }

        private void Mentés_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
