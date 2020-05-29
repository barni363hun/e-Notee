using e_Note.Classes;
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

namespace e_Note
{
    /// <summary>
    /// Interaction logic for Addtable.xaml
    /// </summary>
    public partial class Addtable : Window
    {
        Options options;
        List<Jegyzet> jegyzetek = new List<Jegyzet>();
        private List<ImageBrush> kép;
        public Addtable(Options option)
        {
            options = option;
            InitializeComponent();
            kép = new List<ImageBrush>();
            ImageBrush myimage1 = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Assets/bgphoto.png", UriKind.Absolute)));
            ImageBrush myimage2 = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Assets/Mainbgdark.jpg", UriKind.Absolute)));
            kép.Add(myimage1);
            kép.Add(myimage2);
            foreach (var item in jegyzetek)
            {
                item.oszlopszám = Convert.ToInt32(Oszlopok.Text);
                item.sorokszáma = Convert.ToInt32(Sorok.Text);
            }
            Refresh();
        }

        private void Refresh()
        {
            AddTable.Title = options.language.Content.AddTable_Title;
            Táblázat.Content = options.language.Content.AddTable_Table;
            Oszlop.Content = options.language.Content.AddTable_Column;
            Sor.Content = options.language.Content.AddTable_Row;
            Létrehozás.Content = options.language.Content.AddTable_Create;

            if (options.DarkMode)
            {


                //dark mode


                Létrehozás.Background = new SolidColorBrush(Color.FromArgb(255, 38, 38, 38));
                Létrehozás.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                Létrehozás.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                háttér.Background = kép[1];
                Táblázat.Foreground = Brushes.White;
                Oszlop.Foreground = Brushes.White;
                Sor.Foreground = Brushes.White;

            }
            else
            {
                //light mode


                Létrehozás.Background = new SolidColorBrush(Color.FromArgb(255, 201, 201, 201));
                Létrehozás.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                Létrehozás.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                háttér.Background = kép[0];
                Táblázat.Foreground = Brushes.Black;
                Oszlop.Foreground = Brushes.Black;
                Sor.Foreground = Brushes.Black;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddnewTable addnewtable = new AddnewTable(options);
            addnewtable.Show();
        }
    }
}
