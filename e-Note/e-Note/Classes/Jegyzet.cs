using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Note
{
    public class Jegyzet
    {
        public string Cim;
        public string Tartalom;
        public string[] Címkék;

        private string Cimketömb;

        public Jegyzet(string sor)
        {
            string[] adatok = sor.Split(new string[] { "ZgjGBluXS5bQlKPDGyAa" }, StringSplitOptions.None);
            Cim = adatok[0];
            Tartalom = adatok[1];
            Cimketömb = adatok[2];
            Címkék = Cimketömb.Split(new string[] { "zegShZXeBAxXtoEGTa7P" }, StringSplitOptions.None);
        }

        public Jegyzet()
        {

        }
    }
}
