﻿using e_Note.Classes;
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

            if (jegyzet.Típus == "lista")
            {
                Tartalom.Visibility = Visibility.Hidden;
                listanézet.Visibility = Visibility.Visible;
                
                foreach (var item in options.splitbycommas(jegyzet.Tartalom))
                {
                    CreateATextBox2(item);
                }
            }
            else
            {
                Tartalom.Visibility = Visibility.Visible;
                listanézet.Visibility = Visibility.Hidden;
                Tartalom.Text = jegyzet.Tartalom;

            }
            string címkékek = "";
            foreach (var item in jegyzet.Címkék)
            {
                címkékek += item + ",";
            }
            címkékek = címkékek.Remove(címkékek.Length - 1);
            Címkék.Text = címkékek;
            Refresh();

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

        private void CreateATextBox2(string inputtext)
        {

            TextBox txtb = new TextBox();

            txtb.Height = 30;
            txtb.Name = "tbox";
            txtb.Text = inputtext;
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
            string boxok = "";
            string fajta = "";
            if (listanézet.Visibility == Visibility.Visible)
            {
                foreach (TextBox txbox in Listák.Children)
                {
                    boxok += txbox.Text + ",";
                }
                fajta = "lista";
            }
            else
            {
                boxok = Tartalom.Text;
                fajta = "sima";
            }
            string[] címkék = options.splitbycommas(Címkék.Text);
            Jegyzet újjegyzet = new Jegyzet(fajta, Cim.Text, boxok, címkék);
            options.JegyzetTörléseAFájlból(jindex, lista);
            options.JegyzetHozzáadásAFájlhoz(újjegyzet);
            Close();
        }

        private void listanézet_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tbox = sender as TextBox;
            if (e.Key == Key.Enter)
            {
                CreateATextBox2(" - ");
            }
        }

        private void DeleteJegyzet_Click(object sender, RoutedEventArgs e)
        {
            options.JegyzetTörléseAFájlból(jindex, lista);
            Close();
        }

        private void Noteedit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                MessageBox.Show(options.language.Content.NoteEditor_info, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
