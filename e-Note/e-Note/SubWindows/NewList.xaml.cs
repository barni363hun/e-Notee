using e_Note.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
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
    /// Interaction logic for NewList.xaml
    /// </summary>
    public partial class NewList : Window
    {
        Options options;
        List<Jegyzet> jegyzetek = new List<Jegyzet>();
        private List<ImageBrush> kép;
        public NewList(Options beállitas)
        {
            options = beállitas;
            InitializeComponent();
            kép = new List<ImageBrush>();
            ImageBrush myimage1 = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Assets/bgphoto.png", UriKind.Absolute)));
            ImageBrush myimage2 = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Assets/Mainbgdark.jpg", UriKind.Absolute)));
            kép.Add(myimage1);
            kép.Add(myimage2);
            CreateATextBox1();
            Refresh();
        }
        public void Refresh()
        {
            Window.Title = options.language.Content.NewList_Title;
            L_Tartalom.Content = options.language.Content.NewList_Content;
            L_Címkék.Content = options.language.Content.NewList_Tag;
            Mentés.Content = options.language.Content.NewList_Button;
            L_Cím.Content = options.language.Content.NewList_Cim;
            if (options.DarkMode)
            {
                //dark mode
                Mentés.Background = new SolidColorBrush(Color.FromArgb(255, 38, 38, 38));
                Mentés.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                Mentés.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                háttér.Background = kép[1];
                L_Címkék.Foreground = Brushes.White;
                L_Tartalom.Foreground = Brushes.White;
                L_Cím.Foreground = Brushes.White;
            }
            else
            {
                //light mode
                Mentés.Background = new SolidColorBrush(Color.FromArgb(255, 201, 201, 201));
                Mentés.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                Mentés.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                háttér.Background = kép[0];
                L_Címkék.Foreground = Brushes.Black;
                L_Tartalom.Foreground = Brushes.Black;
                L_Cím.Foreground = Brushes.Black;
            }
            
        }

        private void CreateATextBox1()

        {

            TextBox txtb = new TextBox();

            txtb.Height = 30;

            txtb.Width = 650;
            txtb.HorizontalAlignment = HorizontalAlignment.Right;
            txtb.FontSize = 22;

            

            txtb.Background = new SolidColorBrush(Colors.White);

            txtb.Foreground = new SolidColorBrush(Colors.Black);

            Listák.Children.Add(txtb);

        }



        private void CreateATextBox2()

        {

            TextBox txtb = new TextBox();

            txtb.Height = 30;
            txtb.Name = "tbox";
            txtb.Text = " - ";
            txtb.Width = 620;
            txtb.FontSize = 22;

            txtb.HorizontalAlignment = HorizontalAlignment.Right;


            txtb.Background = new SolidColorBrush(Colors.White);


            txtb.Foreground = new SolidColorBrush(Colors.Black);

            Listák.Children.Add(txtb);
            txtb.SelectionStart = txtb.Text.Length;
            txtb.SelectionLength = 0;
            txtb.Focus();

        }

        private void listanézet_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tbox = sender as TextBox;
            if (e.Key == Key.Enter)
            {
                CreateATextBox2();
            }
        }

        private void Mentés_Click(object sender, RoutedEventArgs e)
        {
            TextBox tbox = sender as TextBox;
            string[] címkék = options.splitbycommas(Címkék.Text);
            Jegyzet felvevendő = new Jegyzet("lista",L_Cim.Text, tbox.Text, címkék);
            options.JegyzetHozzáadásAFájlhoz(felvevendő);
            Close();
        }
    }
}
