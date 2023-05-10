using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucak_Rezervasyonu
{
    internal class Rezervasyon
    {
        public string Ucak { get; set; }
        public string lokasyon { get; set; }
        public string Musteri { get; set; }
        public DateTime TarihveSaat;
        public string KoltukNo;
        public char acik;
        public char kapali;
        public int dolukoltuk;
        public int boskoltuk;

        public Ucak ucak { get; set; }




    }
}
        