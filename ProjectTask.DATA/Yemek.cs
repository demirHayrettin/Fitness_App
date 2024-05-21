using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask.DATA
{
    public class Yemek
    {
        public int YemekId { get; set; }
        public string Ad { get; set; }
        public YemekKategori Kategori { get; set; }
        public List<Besin> Besinler { get; set; }
        public string Tarif { get; set; }
        public string ResimYolu { get; set; }
        public Porsiyon Porsiyon { get; set; }
        public double Kalori => Besinler?.Sum(b => b.Kalori) ?? 0;
    }
}
