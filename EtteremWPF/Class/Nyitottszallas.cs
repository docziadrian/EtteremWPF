using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szalloda
{
    public abstract class NyitottSzallas : Szallas
    {
        private string RecepcioNyitvatartas { get; set; }
        private bool VanSajatParkolo { get; set; }
        private bool BankkartyaElfogadas { get; set; }
    }

}
