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
        private int MaxFerohely { get; set; }
        protected Szallas(int iD, string nev, string cim, decimal ar, string tulajNev, string cegNev, string leiras, string telefon, string email, int szobakSzama, int maxFerohely)
        {
            ID = iD;
            Nev = nev;
            Cim = cim;
            Ar = ar;
            TulajNev = tulajNev;
            CegNev = cegNev;
            Leiras = leiras;
            Telefon = telefon;
            Email = email;
            SzobakSzama = szobakSzama;
            MaxFerohely = maxFerohely;
        }



    }

}
