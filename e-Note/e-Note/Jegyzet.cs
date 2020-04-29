using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Note
{
    class Jegyzet
    {


        public string Cim;
        public string Tartalom;
        public string Cimke;
        public string AlmaCimke;

        public Jegyzet(string sor)
        {
            string[] adatok = sor.Split(new string[] { "ZgjGBluXS5bQlKPDGyAa" }, StringSplitOptions.None);
            Cim = adatok[0];
            Tartalom = adatok[1];
            Cimke = adatok[2];
            string[] cimke = Cimke.Split(new string[] { "zegShZXeBAxXtoEGTa7P" }, StringSplitOptions.None);
            AlmaCimke = cimke[1];
        }

        public Jegyzet()
        {
        }
    }
}
