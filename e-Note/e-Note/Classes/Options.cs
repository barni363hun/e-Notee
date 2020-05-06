using e_Note.Classes.Encryption;
using e_Note.Classes.Leanguages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Note.Classes
{
    public class Options
    {
        public ChosenLanguge language;
        public Crypto crypto;
        public bool DarkMode;
        public string password;
        public string path;
        public Options(string jelszo, string elérésiút)
        {
            language = new ChosenLanguge();
            crypto = new Crypto();
            DarkMode = false;
        }
        public Options()
        {
            language = new ChosenLanguge();
            crypto = new Crypto();
        }
    }
}
