using e_Note.Classes;
using e_Note.Classes.Leanguages;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace e_Note
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(string eNodeData)
        {
            InitializeComponent();
           
            //Test.Content = eNodeData;
        }

        Options options = new Options();
        private void Refresh()
        {
            
        }
        private void Language_Loaded(object sender, RoutedEventArgs e)
        {
            Language.SelectedItem = EN;
        }

        private void Language_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            options.language.ChoseType(((ComboBoxItem)Language.SelectedItem).Content.ToString());
            Refresh();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)
            {

            }
        }
    }
}
