using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szalloda
{
    public class Vendeghaz : Maganszallas
    {
        private int KertKapacitas { get; set; }
        private bool KonyhaHasznalhato { get; set; }
        public Vendeghaz(int iD, string nev, string cim, decimal ar, string tulajNev, string cegNev, string leiras, string telefon, string email, int szobakSzama, int maxFerohely, bool haziallatengedelyezett, bool sajattulajdonbanvan, int kertkapacitas, bool konyhahasznalhato) : base(iD, nev, cim, ar, tulajNev, cegNev, leiras, telefon, email, szobakSzama, maxFerohely, haziallatengedelyezett, sajattulajdonbanvan)
        {
            KertKapacitas = kertkapacitas;
            KonyhaHasznalhato = konyhahasznalhato;
        }
        public override void RovidLeiras()
        {
            Console.WriteLine("Ez egy vendégház!");
        }
    }
}
