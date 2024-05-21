using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask.DATA
{
    public class Porsiyon
    {
        public int PorsiyonId { get; set; }
        public string Ad { get; set; } // Örneğin, Küçük, Orta, Büyük
        public double Miktar { get; set; } // Gram veya mililitre cinsinden
    }
}
