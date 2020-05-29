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
                LoginWindow_LoginButton = "Belépek!",
                LoginWindow_OpenFile = "Fájl megnyitása",
                GetPasswordWindow_Title = "Fájl létrehozása",
                GetPasswordWindow_Szoveg = "Írd be a mesterkulcsot",
                GetPasswordWindow_File = "Kódolt fájl létrehozása",
                MainWindow_Colordark = "Sötét téma",
                MainWindow_Colorlight = "Világos téma",
                MainWindow_Title = "Fő menü",
                Noteeditor_Title = "Jegyzet szerkesztő",
                Noteeditor_Cim = "Cím:",
                Noteeditor_Tartalom = "Jegyzet:",
                Noteeditor_Cimke = "Jegyzethez tartozó cimkék:\n" + "(vesszővel elválasztva)",
                Noteeditor_Button = "Mentés",
                Noteeditor_Delete = "Törlés",
                Notecreator_Title = "Jegyzet készítő",
                Notecreator_Cim = "Cím:",
                Notecreator_Tartalom = "Jegyzet:",
                Notecreator_Cimke = "Jegyzethez tartozó cimkék:\n" + "(vesszővel elválasztva)",
                Notecreator_Button = "Mentés",
                AddWindow_Title = "Hozzáadás",
                AddWindow_Add = "Hozz létre:",
                AddWindow_Note = "Új jegyzetet",
                AddWindow_Table = "Új táblázatot",
                AddWindow_List = "Új felsorolást",
                AddTable_Title = "Táblázat hozzáadása",
                AddTable_Table = "Új táblázat",
                AddTable_Column = "Oszlopok száma:",
                AddTable_Row = "Sorok száma:",
                AddTable_Create = "Létrehozás",
                AddnewTable_Title = "Táblázat",
                AddnewTable_Cim = "Cím:",
                AddnewTable_Tartalom = "Táblázat:",
                AddnewTable_Cimke = "Táblázathoz tartozó cimkék:\n" + "(vesszővel elválasztva)",
                AddnewTable_Mentes = "Mentés",
            };
        }
    }
}
