using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class Kisi
    {
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public int Id { get; set; }
        public string IsimSoyIsim
        {
            get { return Isim +SoyIsim ; }
        }
       
    }    
}
