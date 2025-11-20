using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szalloda
{
    internal class Ertekeles
    {
        public string ErtekeloNev { get; set; }
        public int Pontszam { get; set; }     // 1–5
        public string Szoveg { get; set; }
        public DateTime Datum { get; set; }
        public int SzallasID { get; set; }    // opcionális kapcsolás
        public string Email { get; set; }
    }
}
