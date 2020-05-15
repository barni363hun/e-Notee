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
    /// Interaction logic for NoteEditor.xaml
    /// </summary>
    public partial class NoteEditor : Window
    {
        List<Jegyzet> lista;
        int jindex;
        Jegyzet jegyzet;
        Options options;
        public NoteEditor(List<Jegyzet> inputjegyzetek,int inputjegyzetindex, Options inputoptions)
        {
            options = inputoptions;
            jegyzet = inputjegyzetek[inputjegyzetindex];
            jindex = inputjegyzetindex;
            lista = inputjegyzetek;
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
        private void Kész_Click(object sender, RoutedEventArgs e)
        {
                string[] címkék = Címkék.Text.Split(',');
                Jegyzet újjegyzet = new Jegyzet("sima", Cim.Text, Tartalom.Text, címkék);
                options.JegyzetTörléseAFájlból(jindex, lista);
                options.JegyzetHozzáadásAFájlhoz(újjegyzet);
                Close();
        }

        private void DeleteJegyzet_Click(object sender, RoutedEventArgs e)
        {
            options.JegyzetTörléseAFájlból(jindex, lista);
            Close();
        }
    }
}
