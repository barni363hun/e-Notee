﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Note
{
    public class Jegyzet
    {
        public string Típus { get; set; } //táblázat-alap-felsorolás
        public string Cim { get; set; }
        public string Tartalom { get; set; }
        public string[] Címkék { get; set; }

        public const string adatokelválasztó = "ZgjGBluXS5bQlKPDGyAa";
        public const string címkékelválasztó = "zegShZXeBAxXtoEGTa7P";
        public const string jegyzetelválasztó = "hVNM8wwutyDL9479NRbP";

        public Jegyzet(string típus,string cím,string tartalom,string[] címkék)
        {
            Típus = típus;
            Cim = cím;
            Tartalom = tartalom;
            Címkék = címkék;
        }
    }
}
