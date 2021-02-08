using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri[] musteriler = new Musteri[]
            {
                new Musteri{Id=1,Ad="Fuat Atıf",Soyad="Tufa",TCKN="100000000000"},
                new Musteri{Id=2,Ad="Nuh ",Soyad="Tufan",TCKN="100000000000"},
                new Musteri{Id=3,Ad="Rıza ",Soyad="Silahlıpoda",TCKN="100000000000"},
            };

            MusteriManager manager = new MusteriManager();

            Console.WriteLine("----------Musteri Listleleme----------");
            manager.MusteriListele(musteriler);

            Console.WriteLine("----------Musteri Silme----------");
            manager.MusteriSil(musteriler[0]);

            Console.WriteLine("----------Musteri Ekleme----------");
            manager.MusteriEkle(musteriler[2]);
        }
    }
}
