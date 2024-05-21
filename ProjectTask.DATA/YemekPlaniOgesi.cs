using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask.DATA
{
    public class YemekPlaniOgesi
    {
        public int YemekPlaniOgesiId { get; set; }
        public int YemekId {  get; set; }
        public Yemek Yemek { get; set; }

        public int OgunId { get; set; }
        public Ogun Ogun { get; set; }
        public DateTime Saat { get; set; } // Yemek zamanı
    }
}
