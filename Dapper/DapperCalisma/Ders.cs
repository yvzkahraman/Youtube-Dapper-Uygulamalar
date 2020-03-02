using System.Collections.Generic;

namespace DapperCalisma
{
    public class Ders
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Ucret { get; set; }

        public List<Ogrenci> Ogrenciler { get; set; }
    }
}