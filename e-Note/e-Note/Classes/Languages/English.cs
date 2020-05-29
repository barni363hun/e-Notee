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
                Noteeditor_Cimke = "Notes tags:\n"+"(comma separated)",
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
                AddnewTable_Mentes = "Save"
            };
        }
    }
}
