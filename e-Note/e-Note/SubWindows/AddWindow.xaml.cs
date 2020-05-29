using e_Note.Classes;
using e_Note.SubWindows;
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
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        Options options;
        List<Jegyzet> jegyzetek = new List<Jegyzet>();
        private List<ImageBrush> kép;
        public AddWindow(Options test)
        {
            options = test;
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
            Addwindow.Title = options.language.Content.AddWindow_Title;
            Add.Content = options.language.Content.AddWindow_Add;
            Jegyzet.Content = options.language.Content.AddWindow_Note;
            Táblázat.Content = options.language.Content.AddWindow_Table;
            Felsorolás.Content = options.language.Content.AddWindow_List;

            if (options.DarkMode)
            {


                //dark mode


                Jegyzet.Background = new SolidColorBrush(Color.FromArgb(255, 38, 38, 38));
                Jegyzet.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                Jegyzet.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

                Táblázat.Background = new SolidColorBrush(Color.FromArgb(255, 38, 38, 38));
                Táblázat.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                Táblázat.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

                Felsorolás.Background = new SolidColorBrush(Color.FromArgb(255, 38, 38, 38));
                Felsorolás.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                Felsorolás.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                háttér.Background = kép[1];
                Add.Foreground = Brushes.White;
            }
            else
            {
                //light mode


                Jegyzet.Background = new SolidColorBrush(Color.FromArgb(255, 201, 201, 201));
                Jegyzet.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                Jegyzet.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));

                Táblázat.Background = new SolidColorBrush(Color.FromArgb(255, 201, 201, 201));
                Táblázat.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                Táblázat.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));

                Felsorolás.Background = new SolidColorBrush(Color.FromArgb(255, 201, 201, 201));
                Felsorolás.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                Felsorolás.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                háttér.Background = kép[0];
                Add.Foreground = Brushes.Black;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NoteCreator NoteCreatorWindow = new NoteCreator(options);
            NoteCreatorWindow.Show();
        }

        private void table_Click(object sender, RoutedEventArgs e)
        {
            Addtable addtable = new Addtable(options);
            addtable.Show();
        }
    }
}
