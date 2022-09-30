using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmProje
{
    internal class KupProfil:TemelUrun
    {
        public decimal KisaKenar { get; set; }
        public override decimal TabanAlani()
        {
            return KisaKenar*KisaKenar;
        }
        public override decimal Hacim()
        {
            return TabanAlani()*KisaKenar;
        }
        public KupProfil()
        {
            KupProfil.SekilAd = "Küp";
        }
    }
}
