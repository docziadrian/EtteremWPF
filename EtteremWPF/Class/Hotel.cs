using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szalloda
{
    public class Hotel : NyitottSzallas
    {
        public Hotel(int iD, string nev, string cim, decimal ar, string tulajNev, string cegNev, string leiras, string telefon, string email, int szobakSzama, int maxFerohely, string receprioNyitvatartas, bool vansajatparkolo, bool bankkartyaelfogadas, int csillagokSzama, bool wellnessVan, bool medenceVan, int emeletekSzama, bool liftVan) : base(iD, nev, cim, ar, tulajNev, cegNev, leiras, telefon, email, szobakSzama, maxFerohely, receprioNyitvatartas, vansajatparkolo, bankkartyaelfogadas)
        {
            CsillagokSzama = csillagokSzama;
            WellnessVan = wellnessVan;
            MedenceVan = medenceVan;
            EmeletekSzama = emeletekSzama;
            LiftVan = liftVan;
        }
        private int CsillagokSzama { get; set; }
        private bool WellnessVan { get; set; }
        private bool MedenceVan { get; set; }
        private int EmeletekSzama { get; set; }
        private bool LiftVan { get; set; }
        public override void RovidLeiras()
        {
            Console.WriteLine("Ez egy hotel!");
        }
    }
}
