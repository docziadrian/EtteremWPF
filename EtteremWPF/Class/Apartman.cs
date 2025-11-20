using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szalloda
{
    public class Apartman : NyitottSzallas
    {
        public Apartman(string recepcioNyitvatartas, bool vanSajatParkolo, bool bankkartyaElfogadas) : base(recepcioNyitvatartas, vanSajatParkolo, bankkartyaElfogadas)
        {
        }

        private bool KonyhaFelszerelt { get; set; }
        private bool SajatBejarat { get; set; }
        private bool Legkondicionalt { get; set; }
    

    }

}
