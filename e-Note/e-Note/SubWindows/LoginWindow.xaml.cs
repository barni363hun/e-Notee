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
using System.IO;
using System.Windows.Media.Media3D;
using Microsoft.Win32;
using System.Windows.Media.TextFormatting;
using e_Note.Classes.Encryption;

namespace e_Note.SubWindows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        Options options = new Options();
        string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        bool fileOpeneble = false;
        public LoginWindow()
        {
            InitializeComponent();
            Refresh();
            //File.WriteAllText(eNoteData, Options.crypto.EncryptStringAES("titok","password")); //eNoteData generálás
        }


        private void Refresh()
        {
            Window.Title = options.language.Content.LoginWindow_Title;
            Input.Content = options.language.Content.LoginWindow_Input;
        }
        private void Choser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            options.language.ChoseType(((ComboBoxItem)Choser.SelectedItem).Content.ToString());
            Refresh();
        }
        private void Choser_Loaded(object sender, RoutedEventArgs e)
        {
            Choser.SelectedItem = EN;
        }
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(path);
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "e-Note Data (*.eNoteData)|*.eNoteData";
            if (openFileDialog.ShowDialog() == true)
            {
                fileOpeneble = openFileDialog.CheckFileExists;
                
            }
            
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (fileOpeneble)
            {
                if (Passw.Password!="")
                {
                    string loginable = options.crypto.DecryptStringAES(File.ReadAllText(openFileDialog.FileName), Passw.Password);
                    if (loginable != "nope")
                    {
                        MainWindow mainWindow = new MainWindow(loginable);
                        Window.Close();
                        mainWindow.Show();
                    }
                }
            }
            else
            {
                 //ide kell rakni feltételeket
            }
        }
    }
}
