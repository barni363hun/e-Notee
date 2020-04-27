using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Note.Classes.Leanguages
{
    class Hungarian
    {
        public string name = "Hungarian";
        public string mark = "HU";
        public LanguageContent Content;

        public Hungarian()
        {
            Content = new LanguageContent
            {
                LoginWindow_Input = "Írd be a mester-kulcsot:",
                LoginWindow_Title = "Bejelentkezés",
                LoginWindow_LoginButton = "Belépek!"
            };
        }
    }
}
