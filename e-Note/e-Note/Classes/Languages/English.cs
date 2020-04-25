using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Note.Classes.Leanguages
{
    class English
    {
        public string name = "English";
        public string mark = "EN";
        public LanguageContent Content;

        public English()
        {
            Content = new LanguageContent
            {
                LoginWindow_Input = "Type in the master-key:",
                LoginWindow_Title = "Login"
            };
        }
    }
}
