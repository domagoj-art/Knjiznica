﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnjiznicaAPI.ViewModels
{
    public class KnjigaViewModel
    {
        public int KnjiznicaID { get; set; }
        public int ID { get; set; }
        public string NazivKnjige { get; set; }
        public string Pisac { get; set; }
    }
}