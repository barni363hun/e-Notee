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

namespace e_Note.SubWindows
{
    /// <summary>
    /// Interaction logic for NoteEditor.xaml
    /// </summary>
    public partial class NoteEditor : Window
    {
        List<Jegyzet> lista;
        int jindex;
        Jegyzet jegyzet;
        Options options;
        private List<ImageBrush> kép;
        public NoteEditor(List<Jegyzet> inputjegyzetek,int inputjegyzetindex, Options inputoptions)
        {
            options = inputoptions;
            jegyzet = inputjegyzetek[inputjegyzetindex];
            jindex = inputjegyzetindex;
            lista = inputjegyzetek;
            kép = new List<ImageBrush>();
            ImageBrush myimage1 = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Assets/bgphoto.png", UriKind.Absolute)));
            ImageBrush myimage2 = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Assets/Mainbgdark.jpg", UriKind.Absolute)));
            kép.Add(myimage1);
            kép.Add(myimage2);
            InitializeComponent();
            Cim.Text = jegyzet.Cim;
            Tartalom.Text = jegyzet.Tartalom;
            string címkékek = "";
            foreach (var item in jegyzet.Címkék)
            {
                címkékek += item + ",";
            }
            címkékek = címkékek.Remove(címkékek.Length - 1);
            Címkék.Text = címkékek;
            Refresh();
        }

        private void Refresh()
        {
            Noteedit.Title = options.language.Content.Noteeditor_Title;
            L_Cím.Content = options.language.Content.Noteeditor_Cim;
            L_Tartalom.Content = options.language.Content.Noteeditor_Tartalom;
            L_Címkék.Content = options.language.Content.Noteeditor_Cimke;
            Kész.Content = options.language.Content.Noteeditor_Button;
            DeleteJegyzet.Content = options.language.Content.Noteeditor_Delete;
            if (options.DarkMode)
            {


                //dark mode

                DeleteJegyzet.Background = new SolidColorBrush(Color.FromArgb(255, 38, 38, 38));
                DeleteJegyzet.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                DeleteJegyzet.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
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

                DeleteJegyzet.Background = new SolidColorBrush(Color.FromArgb(255, 200, 0, 0));
                DeleteJegyzet.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                DeleteJegyzet.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
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
                Jegyzet újjegyzet = new Jegyzet("sima", Cim.Text, Tartalom.Text, címkék);
                options.JegyzetTörléseAFájlból(jindex, lista);
                options.JegyzetHozzáadásAFájlhoz(újjegyzet);
                Close();
        }

        private void DeleteJegyzet_Click(object sender, RoutedEventArgs e)
        {
            options.JegyzetTörléseAFájlból(jindex, lista);
            Close();
        }
    }
}
