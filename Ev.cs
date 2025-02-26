using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sube2.EmlakciApp
{
    internal class Ev
    {
        //Belirtilmezse veri tipinin başına private olarak tanımlanır
        //Private veri tipleri sadece class içerisinden erişilebilir üyeler tanımlar.
        //Public class dışından da erişilebilir üyeler tanımlar.
        public int odasayisi;
        public string semt;
        public double alan;
        public int katno;

        public string EvBilgileri()
        {
          return  ($"Oda Sayısı: {odasayisi}\nKat No: {katno}\nSemt: {semt}\nAlan: {alan}\n"); //parametre tanımlanmadığında ev.odasayisi yerine this.odasayisi olarak görülür
        }
    }

}

