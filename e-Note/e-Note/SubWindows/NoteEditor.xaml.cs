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
        Jegyzet jegyzet;
        public NoteEditor(Jegyzet inputjegyzet)
        {
            jegyzet = inputjegyzet;
            InitializeComponent();
            Cim.Text = jegyzet.Cim;
            Tartalom.Text = jegyzet.Tartalom;
            string címkékek = "";
            foreach (var item in jegyzet.Címkék)
            {
                címkékek += item + ",";
            }
            címkékek = címkékek.Remove(címkékek.Length - 1);
            Címkék.Text = címkékek;
        }
        public Jegyzet ResponseNote
        {
            get { return jegyzet; }
            set { jegyzet = setjegyzetdata(); }
        }
        
        private Jegyzet setjegyzetdata()
        {
            string[] címkék = Címkék.Text.Split(',');
            return new Jegyzet("sima", Cim.Text, Tartalom.Text, címkék);
        }
        private void Kész_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
