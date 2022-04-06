using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class Ucus
    {
        public string UcusKodu { get; set; }
        public DateTime Tarih { get; set; }
        public Decimal Ucret{ get; set; }
        public HavaLimani Kalkıs { get; set; }
        public HavaLimani Varıs { get; set; }
        public Ucak Ucak { get; set; }

        public bool KoltukBosMu(int KoltukNo)
        {
          
            for (i = 0; i < Ucak.Kapasite i++)
            {
                Ucak Temp = (Ucak.Kapasite)[i];
                if ((Temp.Kapasite)[i] != KoltukNo )
                {
                    List<int> bosKoltuklar = new List<int>();
                    bosKoltuklar.Add((Ucak.Kapasite)[i]);
                }
            }
                
        }

    }


}


