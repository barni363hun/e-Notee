using e_Note.Classes;
using e_Note.Classes.Leanguages;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        Options Options; 
        public LoginWindow()
        {
            Options = new Options();
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            Window.Title = Options.Language.Content.LoginWindow_Title;
            Input.Content = Options.Language.Content.LoginWindow_Input;
        }


        private void Choser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Options.Language.ChoseType(((ComboBoxItem)Choser.SelectedItem).Content.ToString());
            Refresh();
        }

        private void Choser_Loaded(object sender, RoutedEventArgs e)
        {
            Choser.SelectedItem = EN;
        }
    }
}
