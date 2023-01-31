﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnjiznicaAPI.ViewModels
{
    public class ZaposlenikViewModel
    {
        public int KnjiznicaID { get; set; }
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public int Sifra { get; set; }
        public string KontaktBroj { get; set; }
        public System.DateTime PocetakRada { get; set; }

    }
}