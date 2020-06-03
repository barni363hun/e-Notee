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
                LoginWindow_Title = "Login",
                LoginWindow_LoginButton = "LoginButton",
                LoginWindow_OpenFile = "Open file",
                GetPasswordWindow_Title = "Create file",
                GetPasswordWindow_Szoveg = "Enter the master key",
                GetPasswordWindow_File = "Create an encrypted file",
                MainWindow_Colordark = "Dark mod",
                MainWindow_Colorlight = "Light mod",
                MainWindow_Title = "Main menu",
                Noteeditor_Title = "Note editor",
                Noteeditor_Cim = "Title:",
                Noteeditor_Tartalom = "Note:",
                Noteeditor_Cimke = "Notes tags:\n" + "(comma separated)",
                Noteeditor_Button = "Save",
                Noteeditor_Delete = "Delete",
                Notecreator_Title = "Note creator",
                Notecreator_Cim = "Title:",
                Notecreator_Tartalom = "Note:",
                Notecreator_Cimke = "Notes tags:\n" + "(comma separated)",
                Notecreator_Button = "Save",
                AddWindow_Title = "Addition",
                AddWindow_Add = "Create:",
                AddWindow_Note = "New note",
                AddWindow_Table = "New table",
                AddWindow_List = "New listing",
                AddTable_Title = "Add table",
                AddTable_Table = "New table",
                AddTable_Column = "Columns number:",
                AddTable_Row = "Rows number:",
                AddTable_Create = "Create",
                AddnewTable_Title = "Table",
                AddnewTable_Cim = "Title:",
                AddnewTable_Tartalom = "Table:",
                AddnewTable_Cimke = "Tables tags:\n" + "(comma separated)",
                AddnewTable_Mentes = "Save",
                MainWindow_info = "" +
                "You can execute commands from the search bar: mode->dark/light, language->HU/EN, view->grid/list, open->'word'(opens all note which contains this 'word'). " +
                "You can edit your notes if you click on them. " +
                "All of your changes will be saved automatically. " +
                "You can create new notes with the '+' button (you cant create tables at now)." +
                "You can refresh your notes with the green button.",
                LoginWindow_info = "You have to open your save file for login. If you dont have one just click on the login button.",
                AddWindow_info = "You cant create tables at now.",
                NoteEditor_info = "You can add note tags separated with with comma's. You can search for the tags on the main window but cant see them.",
                LoginWindow_exampleNote = "I am just an examole note",
                NewList_Title = "List creator",
                NewList_Content = "List:",
                NewList_Tag = "Lists tags:\n" + "(comma separated)",
                NewList_Button = "Save",
                NewList_Cim = "Title:"
            };
        }
    }
}
