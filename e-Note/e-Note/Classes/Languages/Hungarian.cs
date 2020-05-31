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
                MainWindow_info = "" +
                "A keresőmező ből parancsok is indíthatóak: mode->dark/light, language->HU/EN, view->grid/list, open->'keresőszó'(minden találatot megnyit szerkesztésre). " +
                "A jegyzetre történő dupla kattintássak szerkesztheted a jegyzeteidet. " +
                "Minden jegyzet automatikusan mentésre kerül. " +
                "A '+' feliratú gombra kattintásával hozhatsz létre új jegyzetet (még csak sima jegyzet hozható létre).",
                LoginWindow_info = "A bejelentkezéshez szükséges megnyitnod a mentésfájlodat. Ha még nincsen akkor a bejelentkezés gombra kattintva hozhatsz létre eggyet.",
                AddWindow_info = "Még csak sima jegyzetet tudsz csinálni.",
                NoteEditor_info = "A címkékhez vesszővel elválaszva tudsz megadni szavakat amelyekre lehet keresni viszont nem látszódnak.",
                LoginWindow_exampleNote = "Ha bármilyen segítségre lenne szükséged nyomd meg az f1-gombot"
            };
        }
    }
}
