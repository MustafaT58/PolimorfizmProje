using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmProje
{
    internal class SlindirProfil:TemelUrun
    {
        public decimal YariCap { get; set; }
        public override decimal TabanAlani()
        {
            return Convert.ToDecimal(Math.PI)*(YariCap*YariCap);
        }
        public SlindirProfil()
        {
            SlindirProfil.SekilAd = "Silindir";
        }
    }
}
