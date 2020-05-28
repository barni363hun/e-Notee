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
    /// Interaction logic for Addtable.xaml
    /// </summary>
    public partial class Addtable : Window
    {
        List<Jegyzet> jegyzetek = new List<Jegyzet>();
        public Addtable()
        {
            InitializeComponent();
            foreach (var item in jegyzetek)
            {
                item.oszlopszám = Convert.ToInt32(Oszlopok.Text);
                item.sorokszáma = Convert.ToInt32(Sorok.Text);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddnewTable addnewtable = new AddnewTable();
            addnewtable.Show();
        }
    }
}
