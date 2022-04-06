using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class HavaYolu
    {
        
        public string Isim { get; set; }
        public string Code { get; set; }
        public virtual Ucak Ucak { get; set; }

        /*{ get {return UcakSayısı; }
            set {int UcakSayısı = 0;
                 UcakSayısı += (UcakEkle);} } */
    }
    
 }



    