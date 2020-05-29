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
    /// Interaction logic for GetPasswordWindow.xaml
    /// </summary>
    public partial class GetPasswordWindow : Window
    {
        Options options;
        public GetPasswordWindow(Options opt)
        {
            options = opt;
            InitializeComponent();
            Refresh();
        }
        private void Refresh()
        {
           Window.Title = options.language.Content.GetPasswordWindow_Title;
            Szoveg.Text = options.language.Content.GetPasswordWindow_Szoveg;
            Newfile.Content = options.language.Content.GetPasswordWindow_File;
        }
        public string ResponseText
        {
            get { return ResponseTextBox.Password; }
            set { ResponseTextBox.Password = value; }
        }

        private void OKButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
