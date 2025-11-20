using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szalloda
{
    public abstract class Szallas
    {
        private int ID { get; set; }
        private string Nev { get; set; }
        private string Cim { get; set; }
        private decimal Ar { get; set; }
        private string TulajNev { get; set; }
        private string CegNev { get; set; }

        private string Leiras { get; set; }
        private string Telefon { get; set; }
        private string Email { get; set; }

        private int SzobakSzama { get; set; }
        private int MaxFeroh { get; set; }

        private List<Ertekeles> Ertekelesek { get; set; } = new();

        private double AtlagErtekeles =>
            Ertekelesek.Count == 0 ? 0 : Ertekelesek.Average(e => e.Pontszam);
    }

}
