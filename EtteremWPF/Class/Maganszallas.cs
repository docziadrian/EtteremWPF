using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szalloda
{
    public abstract class Maganszallas : Szallas
    {
        protected Maganszallas(int iD, string nev, string cim, decimal ar, string tulajNev, string cegNev, string leiras, string telefon, string email, int szobakSzama, int maxFerohely, bool haziallatengedelyezett, bool sajattulajdonbanvan) : base(iD, nev, cim, ar, tulajNev, cegNev, leiras, telefon, email, szobakSzama, maxFerohely)
        {
            HaziallatEngedelyezett = haziallatengedelyezett;
            SajatTulajdonbanVan = sajattulajdonbanvan;
        }
        private bool HaziallatEngedelyezett { get; set; }
        private bool SajatTulajdonbanVan { get; set; }
    }
}
