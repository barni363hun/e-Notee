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
        public Options()
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
                    /*jegyzet.Cim = adatok[0];
                    jegyzet.Tartalom = adatok[1];
                    jegyzet.Típus = adatok[3];*/
                    jegyzetekek.Add(jegyzet);
                }
                
            }
            return jegyzetekek;
        }
        public void JegyzetHozzáadásAFájlhoz(Jegyzet hozzáadandó)
        {
            List<Jegyzet> lista = this.Fájlbeolvas();
            lista.Add(hozzáadandó);
            /*foreach (var item in lista)
            {
                L_Cím.Content = item.Cim;
                L_Tartalom.Content = item.Tartalom;
            }*/
            string újfájl = this.Jegyzettömbstringbe(lista);
            File.WriteAllText(this.path, this.crypto.EncryptStringAES(újfájl, this.password));
        }
        public void JegyzetTörléseAFájlból(int törlendőindexe,List<Jegyzet> jegyzets)
        {
            if (törlendőindexe == 0)
            {
                jegyzets.Clear();
            }
            else
            {
                jegyzets.Remove(jegyzets[törlendőindexe]);
            }
            string újfájl = this.Jegyzettömbstringbe(jegyzets);
            File.WriteAllText(this.path, this.crypto.EncryptStringAES(újfájl, this.password));

            //List<Jegyzet> lista = this.Fájlbeolvas();
            //for (int i = 0; i < lista.Count; i++)
            //{
            //    if (lista[i].Equals(törlendő))
            //    {
            //        return "siker";
            //        //lista.Remove(jegyzet);
            //        string újfájl = this.Jegyzettömbstringbe(lista);
            //        File.WriteAllText(this.path, this.crypto.EncryptStringAES(újfájl, this.password));
            //    }
            //}
            //return "sikertelen";
        }
    }
}
