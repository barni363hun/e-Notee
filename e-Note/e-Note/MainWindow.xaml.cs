﻿using e_Note.Classes;
using e_Note.Classes.Leanguages;
using e_Note.SubWindows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        Options options;
        List<Jegyzet> jegyzetek = new List<Jegyzet>();
        List<Jegyzet> kiírandójegyzetek = new List<Jegyzet>();
        private List<ImageBrush> kép;
       

        public MainWindow(Options beállítások)
        {
            options = beállítások;
            InitializeComponent();
            kép = new List<ImageBrush>();
            ImageBrush myimage1 = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Assets/Mainbglight.jpg", UriKind.Absolute)));
            ImageBrush myimage2 = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Assets/Mainbgdark.jpg", UriKind.Absolute)));
            kép.Add(myimage1);
            kép.Add(myimage2);
            jegyzetek = options.Fájlbeolvas();
            Refresh();
        }
        
        private void Refresh()
        {
            Main.Title = options.language.Content.MainWindow_Title;

            if (options.DarkMode)
            {
                //dark mode
                SwitchColor.Content = options.language.Content.MainWindow_Colorlight;
                SwitchColor.Background = new SolidColorBrush(Color.FromArgb(255, 38, 38, 38));
                SwitchColor.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                SwitchColor.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                háttér.Background = kép[1];
                foreach (var item in jegyzetek)
                {
                    item.bgcolor = "#FF262626";
                    item.fgcolor = "#FFFFFFFF";
                    
                }
                
            }
            else
            {
                //light mode
                SwitchColor.Content = options.language.Content.MainWindow_Colordark;
                SwitchColor.Background = new SolidColorBrush(Color.FromArgb(255, 255, 143, 45));
                SwitchColor.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                SwitchColor.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                háttér.Background = kép[0];
                foreach (var item in jegyzetek)
                {
                    item.bgcolor = "#FFFF9624";
                    item.fgcolor = "#FF000000";
                   
                }
            }
            JegyzetekMegjelenítéseGridesen.ItemsSource = new List<Jegyzet>();
            JegyzetekMegjelenítéseListásan.ItemsSource = new List<Jegyzet>();
            JegyzetekMegjelenítéseGridesen.ItemsSource = jegyzetek;
            JegyzetekMegjelenítéseListásan.ItemsSource = jegyzetek;
        }

        

        private bool EgyezésKereséseAjegyzetben(Jegyzet jegyzet,string kifejezés)
        {
            
            if (jegyzet.Cim.Contains(kifejezés) || jegyzet.Tartalom.Contains(kifejezés) || jegyzet.Típus.Contains(kifejezés))
            {
                return true;
            }
            foreach (var item in jegyzet.Címkék)
            {
                if (item.Contains(kifejezés))
                {
                    return true;
                }
            }
            return false;
        }
        private void Kereso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                List<Jegyzet> összesjegyzet = options.Fájlbeolvas();
                if (Kereso.Text != "")
                {
                    if (Kereso.Text.Contains("->"))
                    {
                        string[] keresősor = Kereso.Text.Split(new[] { "->" }, StringSplitOptions.None);
                        string parancs = keresősor[0];
                        string minekaparancsa = keresősor[1];
                        if (parancs == "mode")
                        {
                            if (minekaparancsa == "light")
                            {
                                options.DarkMode = false;
                            }
                            if (minekaparancsa == "dark")
                            {
                                options.DarkMode = true;
                            }
                        }
                        if (parancs == "view")
                        {
                            if (minekaparancsa == "list")
                            {
                                View.SelectedItem = List;
                            }
                            if (minekaparancsa == "grid")
                            {
                                View.SelectedItem = Grid;
                            }
                        }
                        if (parancs == "language")
                        {
                            if (minekaparancsa == "EN")
                            {
                                Language.SelectedItem = EN;
                            }
                            if (minekaparancsa == "HU")
                            {
                                Language.SelectedItem = HU;
                            }
                        }
                        if (parancs == "open")
                        {
                            List<Jegyzet> jegyzets = options.Fájlbeolvas(); //nem olyan jó de tartalom alapján nyitja meg az editort
                            
                            for (int i = 0; i < jegyzets.Count; i++)
                            {
                                if (jegyzets[i].Cim.Contains(minekaparancsa) || jegyzets[i].Tartalom.Contains(minekaparancsa) || jegyzets[i].Típus.Contains(minekaparancsa))
                                {
                                    NoteEditor EditNote = new NoteEditor(jegyzets, i, options);
                                    EditNote.Show();
                                }
                            }
                        }
                        if (parancs == "new")
                        {
                            if (minekaparancsa == "note")
                            {
                                NoteCreator NoteCreatorWindow = new NoteCreator(options);
                                NoteCreatorWindow.Show();
                            }
                            if (minekaparancsa == "table")
                            {
                                Addtable addtable = new Addtable(options);
                                addtable.Show();
                            }
                        }

                    }
                    else
                    {
                        kiírandójegyzetek.Clear();
                        foreach (Jegyzet jegyzetitem in összesjegyzet)
                        {
                            if (EgyezésKereséseAjegyzetben(jegyzetitem, Kereso.Text))
                            {
                                kiírandójegyzetek.Add(jegyzetitem);
                            }
                        }
                        jegyzetek = kiírandójegyzetek;
                    }
                    
                }
                else
                {
                    jegyzetek = összesjegyzet;
                }
            }
            Refresh();
        }
        private void View_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            Refresh();
        }
        private void Language_Loaded(object sender, RoutedEventArgs e)
        {
            Language.SelectedItem = EN;
        }
        private void View_Loaded(object sender, RoutedEventArgs e)
        {
            View.SelectedItem = Grid;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            options.DarkMode = !options.DarkMode;
            Refresh();
        }
        private void AddNote_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addwindow = new AddWindow(options);
            addwindow.Show();
        }
        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
            jegyzetek = options.Fájlbeolvas();
            Refresh();
        }
        private void Grid_Selected(object sender, RoutedEventArgs e)
        {
            gridnézet.Visibility = Visibility.Visible;
            listanézet.Visibility = Visibility.Hidden;
        }
        private void List_Selected(object sender, RoutedEventArgs e)
        {
            gridnézet.Visibility = Visibility.Hidden;
            listanézet.Visibility = Visibility.Visible;
        }
        public void jegyzetgrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            List<Jegyzet> jegyzets = options.Fájlbeolvas(); //nem olyan jó de tartalom alapján nyitja meg az editort
            TextBox jegyzetTextbox = (TextBox)sender;
            for (int i = 0; i < jegyzets.Count; i++)
            {
                if (jegyzets[i].Tartalom == jegyzetTextbox.Text)
                {
                    NoteEditor EditNote = new NoteEditor(jegyzets, i, options);
                    EditNote.Show();
                }
            }
        }
        private void Language_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            options.language.ChoseType(((ComboBoxItem)Language.SelectedItem).Content.ToString());
            Refresh();
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(options.language.Content.MainWindow_info, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                MessageBox.Show(options.language.Content.MainWindow_info, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Refreshbutton_Click(object sender, RoutedEventArgs e)
        {
            jegyzetek = options.Fájlbeolvas();
            Refresh();
        }
    }
}
