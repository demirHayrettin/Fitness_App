using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask.DATA
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public double Boy { get; set; } // Boy cm cinsinden
        public double Kilo { get; set; } // Kilo kg cinsinden
        public string Email { get; set; }
        public string Sifre { get; set; }
    }
}
