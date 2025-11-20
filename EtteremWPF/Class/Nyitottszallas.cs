using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szalloda
{
    public abstract class NyitottSzallas : Szallas
    {
        protected NyitottSzallas(int iD, string nev, string cim, decimal ar, string tulajNev, string cegNev, string leiras, string telefon, string email, int szobakSzama, int maxFerohely, string receprioNyitvatartas, bool vansajatparkolo, bool bankkartyaelfogadas) : base(iD, nev, cim, ar, tulajNev, cegNev, leiras, telefon, email, szobakSzama, maxFerohely)
        {
            RecepcioNyitvatartas = receprioNyitvatartas;
            VanSajatParkolo = vansajatparkolo;
            BankkartyaElfogadas = bankkartyaelfogadas;
        }

        public bool RecepcioNyitvaE(DateTime idopont)
        {
            return true; // Egyszerűsített példa, mindig nyitva van
        }

        public bool ParkoloElerhetoE()
        {
            return VanSajatParkolo;
        }

        public bool BankkartyaElfogadasE()
        {
            return BankkartyaElfogadas;
        }

        private string RecepcioNyitvatartas { get; set; }
        private bool VanSajatParkolo { get; set; }
        private bool BankkartyaElfogadas { get; set; }

    }

}
