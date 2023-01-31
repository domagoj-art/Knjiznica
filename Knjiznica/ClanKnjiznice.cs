using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica
{
    class ClanKnjiznice
    {
        public int KnjiznicaID { get; set; }
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KontaktBroj { get; set; }
        public System.DateTime ClanarinaVrijediDo { get; set; }
        public string ComboBoxName => $"{Ime} {Prezime} {Email} ";
    }
}
