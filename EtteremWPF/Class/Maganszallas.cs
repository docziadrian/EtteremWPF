using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szalloda
{
    public abstract class Maganszallas : Szallas
    {
        private bool HaziallatEngedelyezett { get; set; }
        private bool SajatTulajdonbanVan { get; set; }
    }
}
