using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace DapperCalisma
{
    class Program
    {
        public static string cs = "server=.\\SQLExpress; database=DapperYoutube; user id=sa; password=1;";
        // integrated security=true;
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(cs);

            //con.Execute("insert into Ogrenci values('Alperen','7/24/1995')");

            //con.Execute("insert into Ogrenci values(@ad,@tarih)",new { ad="Yakup",tarih=DateTime.Now.AddYears(-30) });


            //var reader=  con.ExecuteReader("select * from Ogrenci");
            // while (reader.Read())
            // {
            //     Console.WriteLine(reader["Ad"].ToString()+""+reader["DogumTarih"].ToString());
            // }


            //var isim= con.ExecuteScalar<string>("select Ad from Ogrenci where Id=@id", new { id = 3 });

            //con.Execute("insert into Ogrenci values(@isim,@tarih)", new[]
            //{
            //    new {isim=FakeData.NameData.GetFirstName(),tarih=FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-100),DateTime.Now)},
            //     new {isim=FakeData.NameData.GetFirstName(),tarih=FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-100),DateTime.Now)},
            //      new {isim=FakeData.NameData.GetFirstName(),tarih=FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-100),DateTime.Now)},
            //       new {isim=FakeData.NameData.GetFirstName(),tarih=FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-100),DateTime.Now)},
            //        new {isim=FakeData.NameData.GetFirstName(),tarih=FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-100),DateTime.Now)},
            //         new {isim=FakeData.NameData.GetFirstName(),tarih=FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-100),DateTime.Now)},
            //          new {isim=FakeData.NameData.GetFirstName(),tarih=FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-100),DateTime.Now)}
            //});


            //con.Execute("Update Ogrenci set Ad=@ad where Id=@id", new { ad="yavuz2", id = 3 });
            //con.Execute("Delete from Ogrenci where Id=@id", new { id = 15 });

            //var gelen= con.Query<Ogrenci>("select * from Ogrenci");
            //foreach (var item in gelen)
            //{
            //    Console.WriteLine(item.Ad+"  "+item.DogumTarih.ToString("D"));
            //}

            //var gelen = con.QueryFirst<Ogrenci>("select * from Ogrenci");


            //var sql = @"select * from Ogrenci inner join OgrenciAdres
            //            on Ogrenci.Id=OgrenciAdres.OgrenciId where Ogrenci.Id=@id";

            //var sonuc = con.Query<Ogrenci, OgrenciAdres, Ogrenci>(sql,(ogr,a)=> {
            //    if (ogr.Adresler == null)
            //    {
            //        ogr.Adresler = new List<OgrenciAdres>();
            //    }
            //    ogr.Adresler.Add(a);
            //    return ogr;
            //},new {id=1 });


            //var sql = "upOgrenciEkle";
            //con.Execute(sql,
            //    new
            //    {
            //        ad = FakeData.NameData.GetFirstName(),
            //        dogumtarih = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-100), DateTime.Now.AddYears(-20))
            //    }, null, null, System.Data.CommandType.StoredProcedure);



            //var sql = "upOgrenciSil";
            //con.Execute(sql, new { id=5 }, null, null, System.Data.CommandType.StoredProcedure);


            //var sql = "upOgrenciDuzenle";
            //con.Execute(sql, new { id = 1, ad = "yavuz", dogumtarih = DateTime.Now.AddYears(-27) }, null, null, System.Data.CommandType.StoredProcedure);
            // Console.WriteLine("Store procedure çalıştı kontrol ediniz.");

            //var sql = @"select * from Ogrenci 
            //            inner join OgrenciGiris
            //            on Ogrenci.Id= OgrenciGiris.Id
            //            where Ogrenci.Id=1
            //            ";
            //var gelen = con.Query<Ogrenci, OgrenciGiris, Ogrenci>(sql,(o,og)=> {
            //    if (o.OgrenciGiris == null)
            //    {
            //        o.OgrenciGiris = new OgrenciGiris();
            //    }

            //    o.OgrenciGiris = og;
            //    return o;
            //}).FirstOrDefault();


            //var sqldersler = @"select * from Ogrenci
            //                   inner join OgrenciDers
            //                   on Ogrenci.Id=OgrenciDers.OgrenciId
            //                   inner join Ders 
            //                   on OgrenciDers.DersId=Ders.Id
            //                   where Ogrenci.Id=1";
            //var ogrenciler = con.Query<Ogrenci, Ders, Ogrenci>(sqldersler,(o,d)=> {

            //    if (o.Dersler == null)
            //    {
            //        o.Dersler = new List<Ders>();
            //    }
            //    o.Dersler.Add(d);
            //    return o;
            //});

            //List<Ders> dersListesi = new List<Ders>();



            //var ogrencilerodevCevap = con.Query<Ogrenci, Ders, Ogrenci>(sqldersler, (o, d) => {

            //    if (o.Dersler == null)
            //    {
            //        o.Dersler = new List<Ders>();
            //    }
            //    dersListesi.Add(d);
            //    o.Dersler = dersListesi;
            //    return o;
            //}).FirstOrDefault();

            //Console.WriteLine(ogrencilerodevCevap.Ad+" aldığı dersler:");
            //foreach (var item in ogrencilerodevCevap.Dersler)
            //{
            //    Console.WriteLine(item.Ad);
            //}


            //var sqldersler2 = @"select * from Ogrenci
            //                   inner join OgrenciDers
            //                   on Ogrenci.Id=OgrenciDers.OgrenciId
            //                   inner join Ders 
            //                   on OgrenciDers.DersId=Ders.Id
            //                   ";





            //var ogrenciList = new Dictionary<int, Ogrenci>();
            //var ogrenciler2 = con.Query<Ogrenci, Ders, Ogrenci>(sqldersler2, (o, d) => {

            //    Ogrenci gelenOgrenci;

            //    if(!ogrenciList.TryGetValue(o.Id,out gelenOgrenci))
            //    {
            //        gelenOgrenci = o;
            //        ogrenciList.Add(gelenOgrenci.Id, gelenOgrenci);
            //        gelenOgrenci.Dersler = new List<Ders>();
            //    }

            //    gelenOgrenci.Dersler.Add(d);
            //    return gelenOgrenci;
            //}).Distinct();
            con.Open();
            using (var trans = con.BeginTransaction())
            {
                
                var sql = "Update Hesap set Bakiye=400 where Id=1";
                con.Execute(sql,null,trans);
                Console.WriteLine("Para yavuzun hesabından çıktı..");

                var sql2 = "Update Hesap set Bakiye=300 where Id=2";
                con.Execute(sql2,null,trans);

                trans.Commit();
               
            }
            con.Close();
            con.Dispose();


            Console.WriteLine("İşlem tamam");
           
            Console.ReadKey();


        }
    }
}
