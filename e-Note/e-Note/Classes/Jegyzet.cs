using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace e_Note
{
    public class Jegyzet
    {
        public string Típus { get; set; } //táblázat-alap-felsorolás
        public string Cim { get; set; }
        public string Tartalom { get; set; }
        public string[] Címkék { get; set; }
        
        public string bgcolor { get; set; }
        public string fgcolor { get; set; }

        public int oszlopszám { get; set; }
        public int sorokszáma { get; set; }
       
        

        public const string adatokelválasztó = "ZgjGBluXS5bQlKPDGyAa";
        public const string címkékelválasztó = "zegShZXeBAxXtoEGTa7P";
        public const string jegyzetelválasztó = "hVNM8wwutyDL9479NRbP";
        public const string felsoroláselválasztó = "Kp1rYOqKK22zVOeuNx4v";

        public Jegyzet(string típus,string cím,string tartalom,string[] címkék)
        {
            Típus = típus;
            Cim = cím;
            Tartalom = tartalom;
            Címkék = címkék;
        }
    }
}
