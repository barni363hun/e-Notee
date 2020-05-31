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
        bool filejustcreated = false;
        public LoginWindow()
        {
            InitializeComponent();
            Refresh();
        }
        private void Refresh()
        {
            Window.Title = options.language.Content.LoginWindow_Title;
            Input.Content = options.language.Content.LoginWindow_Input;
            Login.Content = options.language.Content.LoginWindow_LoginButton;
            OpenFile.Content = options.language.Content.LoginWindow_OpenFile;
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
                        options = new Options(Passw.Password, openFileDialog.FileName);
                        if (filejustcreated)
                        {
                            Jegyzet example = new Jegyzet("sima", "Hello World!", options.language.Content.LoginWindow_exampleNote, new string[] { "" });
                            options.JegyzetHozzáadásAFájlhoz(example);
                        }
                        MainWindow mainWindow = new MainWindow(options);
                        Window.Close();
                        mainWindow.Show();
                    }
                    else
                    {
                        if (Choser.SelectedItem==EN)
                        {
                            MessageBox.Show("Wrong password!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            MessageBox.Show("Rossz jelszót adtál meg!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        
                    }
                }
                else
                {
                    if (Choser.SelectedItem==EN)
                    {
                        MessageBox.Show("You have not entered a password!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        MessageBox.Show("Nem adtál meg jelszót!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    
                }
            }
            else
            {
                if (Choser.SelectedItem == EN)
                {
                    MessageBoxResult result = MessageBox.Show("Forgot to open your eNoteData file? If you push 'No' I will generate one next to myself. If it is already generated next to me, you cant generate one!", "Did you forget it?", MessageBoxButton.YesNo, MessageBoxImage.Information);
                    if (result == MessageBoxResult.No)
                    {
                        if (!File.Exists(path.Replace("e-Note.exe", "") + "Save.eNoteData"))
                        {
                            GetPasswordWindow GetPassword = new GetPasswordWindow(options);
                            if (GetPassword.ShowDialog() == true)
                            {
                                File.WriteAllText(path.Replace("e-Note.exe", "") + "Save.eNoteData", options.crypto.EncryptStringAES("", GetPassword.ResponseText));
                                filejustcreated = true;
                                Passw.Password = GetPassword.ResponseText;
                                openFileDialog.FileName = (path.Replace("e-Note.exe", "") + "Save.eNoteData");
                            }
                        }
                        else
                        {
                            MessageBox.Show("You cant overwrite an existing save file.","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Elfelejtetted megnyitni az eNoteData fájlodat? Ha nem-re nyomsz generálok egyet magam mellé. Ha van már mellém generálva fájl akkor nem tudsz újat generálni!", "Elfelejtetted?", MessageBoxButton.YesNo, MessageBoxImage.Information);
                    if (result == MessageBoxResult.No)
                    {
                        if (!File.Exists(path.Replace("e-Note.exe", "") + "Save.eNoteData"))
                        {
                            GetPasswordWindow GetPassword = new GetPasswordWindow(options);
                            if (GetPassword.ShowDialog() == true)
                            {
                                File.WriteAllText(path.Replace("e-Note.exe", "") + "Save.eNoteData", options.crypto.EncryptStringAES("", GetPassword.ResponseText));
                                filejustcreated = true;
                                Passw.Password = GetPassword.ResponseText;
                                openFileDialog.FileName = (path.Replace("e-Note.exe", "") + "Save.eNoteData");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nem írhatsz felül egy létező mentést", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                MessageBox.Show(options.language.Content.LoginWindow_info, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
