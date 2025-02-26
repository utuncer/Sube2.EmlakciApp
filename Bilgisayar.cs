using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sube2.EmlakciApp
{
    internal class Bilgisayar
    {
        public string marka;
        public string islemci;
        public string ekrankarti;
        public int ram;

        public string BilgisayarBilgileri()
        {
            return ($"Marka: {marka}\nİslemci: {islemci}\nEkran Kartı: {ekrankarti}\nRam: {ram}\n");
        }
    }
}
