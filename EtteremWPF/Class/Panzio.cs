using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szalloda
{
    internal class Panzio : Maganszallas
    {
        public Panzio(int iD, string nev, string cim, decimal ar, string tulajNev, string cegNev, string leiras, string telefon, string email, int szobakSzama, int maxFerohely, bool haziallatengedelyezett, bool sajattulajdonbanvan, bool reggelivan, int? csillagokszama) : base(iD, nev, cim, ar, tulajNev, cegNev, leiras, telefon, email, szobakSzama, maxFerohely, haziallatengedelyezett, sajattulajdonbanvan)
        {
            ReggeliVan = reggelivan;
            CsillagokSzama = csillagokszama;
        }

        private bool ReggeliVan { get; set; }
        private int? CsillagokSzama { get; set; }    
    }
}
