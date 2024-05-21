using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask.DATA
{
    public class YemekPlani
    {
        public int YemekPlaniId { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
        public List<YemekPlaniOgesi> YemekPlaniOgesi { get; set; }
        public DateTime Tarih { get; set; }
    }
}
