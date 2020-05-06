using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace e_Note.Classes.Leanguages
{
    public class ChosenLanguge
    {

        English eng;
        Hungarian hun;
        public string name { get; private set; }
        public string mark { get; private set; }

        public LanguageContent Content { get; private set; }

        public ChosenLanguge()
        {
            eng = new English();
            hun = new Hungarian();
            name = eng.name;
            mark = eng.mark;
            Content = eng.Content;
        }

        public void ChoseType(string type)
        {
            if (type == "HU")
            {
                name = hun.name;
                mark = hun.mark;
                Content = hun.Content;
            }
            else if (type == "EN")
            {
                name = eng.name;
                mark = eng.mark;
                Content = eng.Content;
            }
        }
    }
}
