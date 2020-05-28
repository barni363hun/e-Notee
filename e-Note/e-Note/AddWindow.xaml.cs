using e_Note.Classes;
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
using System.Windows.Shapes;

namespace e_Note
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        Options options;
        List<Jegyzet> jegyzetek = new List<Jegyzet>();
        public AddWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NoteCreator NoteCreatorWindow = new NoteCreator(options);
            NoteCreatorWindow.Show();
        }

        private void table_Click(object sender, RoutedEventArgs e)
        {
            Addtable addtable = new Addtable();
            addtable.Show();
        }
    }
}
