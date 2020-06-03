using e_Note.Classes.Encryption;
using e_Note.Classes.Leanguages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

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
            crypto = new Crypto();
            language = new ChosenLanguge();
            DarkMode = false;
            password = jelszo;
            path = elérésiút;
        }
        
        public Options() //loginwindownál szükséges félig létrehozni ha nincs még fájl
        {
            crypto = new Crypto();
            language = new ChosenLanguge();
            DarkMode = false;
        }
        private string Jegyzettömbstringbe(List<Jegyzet> jegyzetlista)
        {
            string elv1 = Jegyzet.adatokelválasztó;
            string elv2 = Jegyzet.címkékelválasztó;
            string elv3 = Jegyzet.jegyzetelválasztó;
            string vissza = "";
            foreach (var jegyzet in jegyzetlista)
            {
                vissza += (jegyzet.Cim + elv1 + jegyzet.Tartalom + elv1);

                foreach (var címke in jegyzet.Címkék)
                {
                    vissza += (címke + elv2);
                }
                vissza += (elv1 + jegyzet.Típus);
                if (jegyzet != jegyzetlista.Last())
                {
                    vissza += elv3;
                }
            }
            return vissza;
        }
        public List<Jegyzet> Fájlbeolvas()
        {
            List<Jegyzet> jegyzetekek = new List<Jegyzet>();
            string egész = this.crypto.DecryptStringAES(File.ReadAllText(this.path), this.password);
            foreach (var jegyzetsor in egész.Split(new string[] { Jegyzet.jegyzetelválasztó }, StringSplitOptions.None))
            {
                string[] adatok = jegyzetsor.Split(new string[] { Jegyzet.adatokelválasztó }, StringSplitOptions.None);
                if (adatok[0]!= "")
                {
                    string Cimketömb = adatok[2];
                    string[] jegyzetcímkék = Cimketömb.Split(new string[] { Jegyzet.címkékelválasztó }, StringSplitOptions.None);
                    Jegyzet jegyzet = new Jegyzet(adatok[3], adatok[0], adatok[1], jegyzetcímkék);
                    jegyzetekek.Add(jegyzet);
                }
                
            }
            return jegyzetekek;
        }
        public void JegyzetHozzáadásAFájlhoz(Jegyzet hozzáadandó)
        {
            List<Jegyzet> lista = this.Fájlbeolvas();
            lista.Add(hozzáadandó);
            string újfájl = this.Jegyzettömbstringbe(lista);
            File.WriteAllText(this.path, this.crypto.EncryptStringAES(újfájl, this.password));
        }
        public void JegyzetTörléseAFájlból(int törlendőindexe,List<Jegyzet> jegyzets)
        {
            
                jegyzets.Remove(jegyzets[törlendőindexe]);
            
            string újfájl = this.Jegyzettömbstringbe(jegyzets);
            File.WriteAllText(this.path, this.crypto.EncryptStringAES(újfájl, this.password));
        }
        public string[] splitbycommas(string inputstring)
        {
            List<string> goodWords = new List<string>();

            if (inputstring != "")
            {
                string[] words = inputstring.Split(',');
                foreach (var item in words)
                {
                    if (item != "")
                    {
                        goodWords.Add(item);
                    }
                }
            }
            return goodWords.ToArray();
        }
    }
}
