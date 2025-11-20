using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szalloda
{
    public class Apartman : NyitottSzallas
    {
        public Apartman(string recepcioNyitvatartas, bool vanSajatParkolo, bool bankkartyaElfogadas, bool konyhafelszerelt, bool sajatbejarat, bool legkondi) : base(recepcioNyitvatartas, vanSajatParkolo, bankkartyaElfogadas)
        {
           KonyhaFelszerelt = konyhafelszerelt;
            SajatBejarat = sajatbejarat;
            Legkondicionalt = legkondi;
        }

        private bool KonyhaFelszerelt { get; set; }
        private bool SajatBejarat { get; set; }
        private bool Legkondicionalt { get; set; }

        public override void RovidLeiras()
        {
            Console.WriteLine("Ez egy apartman!");
        }
    }

}
