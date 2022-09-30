using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmProje
{
    internal class TemelUrun:IUrun
    {
        public int Id { get; set; }
        public static string ?SekilAd { get; set; }
        public decimal Yukseklik { get; set; }
        

        public decimal Fire()
        {
            return (Hacim()*30)/100;
        }

        public virtual decimal Hacim()
        {
          return TabanAlani()* Yukseklik;
        }

        public virtual decimal TabanAlani()
        {
            return 0;
        }
    }
}
