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

        public int TeljesArSzamitas(int ejszakakSzama)
        {
            return (int)(this.Ar * ejszakakSzama);
        }
        public bool FoglalhatoE()
        {
            return this.SzobakSzama > 0;
        }
        public void KapcsolatiAdatok()
        {
            Console.WriteLine($"Tulajdonos neve: {this.TulajNev}, Telefon: {this.Telefon}, E-mail címe: {this.Email}");
        }
        public void RovidLeiras()
        {
            Console.WriteLine($"Szállás neve: {this.Nev}, Címe: {this.Cim}, ára éjszakánként: {this.Ar} Ft");
        }
        public void TipusNeve()
        {
            Console.WriteLine($"Szállás típusa: {this.GetType().Name}");
        }
        public bool FeroHelyElegE(int szemelyekSzama)
        {
            return szemelyekSzama <= this.MaxFerohely;
        }
        public bool SzobaFoglalas(int darab)
        {
            if (darab <= this.SzobakSzama)
            {
                this.SzobakSzama -= darab;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SzobaLemondas(int darab)
        {
            this.SzobakSzama += darab;
            return true;
        }
        public void ArNovelese(double szazalek)
        {
            this.Ar += this.Ar * (decimal)(szazalek / 100);
        }
        public void ArCsokkentese(double szazalek)
        {
            this.Ar -= this.Ar * (decimal)(szazalek / 100);
        }
    }

}
