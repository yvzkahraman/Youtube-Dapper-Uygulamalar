using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using System.Text;

namespace DapperCalisma
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public DateTime DogumTarih { get; set; }

        public List<Ders> Dersler { get; set; }
        public OgrenciGiris OgrenciGiris { get; set; }
        public List<OgrenciAdres> Adresler { get; set; }
    }
  
}
