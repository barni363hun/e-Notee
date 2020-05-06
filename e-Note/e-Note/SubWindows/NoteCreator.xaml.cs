using e_Note.Classes;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for NoteCreator.xaml
    /// </summary>
    public partial class NoteCreator : Window
    {
        Options options;
        List<Jegyzet> jegyzetek = new List<Jegyzet>();
        public NoteCreator(Options beállítások)
        {
            options = beállítások;
            InitializeComponent();
        }

        private void Kész_Click(object sender, RoutedEventArgs e)
        {
            string eNoteData = options.crypto.DecryptStringAES(options.path,options.password);
            //eNoteData stringből jegyzet tömb majd visszafordít
            File.WriteAllText(options.path, options.crypto.EncryptStringAES("", options.password));
        }
    }
}
