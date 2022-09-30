using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmProje
{
    internal class DikdortgenProfil : TemelUrun
    {
        public decimal KisaKenar { get; set; }
        public decimal UzunKenar { get; set; }
        public override decimal TabanAlani()
        {
            return KisaKenar*UzunKenar;
        }
        public DikdortgenProfil()
        {
            DikdortgenProfil.SekilAd = "Dikdörtgen";
        }
    }
}
