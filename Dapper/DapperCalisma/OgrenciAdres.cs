using System;
using System.Collections.Generic;
using System.Text;

namespace DapperCalisma
{
    public class OgrenciAdres
    {
        public int Id { get; set; }
        public string Tanim { get; set; }
        public int OgrenciId { get; set; }

        public Ogrenci Ogrenci { get; set; }
    }
}
