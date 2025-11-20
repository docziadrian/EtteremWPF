using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szalloda
{
    internal class Hotel : Nyitottszallas
    {
        public int CsillagokSzama { get; set; }
        public bool WellnessVan { get; set; }
        public bool MedenceVan { get; set; }
        public int EmeletekSzama { get; set; }
        public bool LiftVan { get; set; }
    }
}
