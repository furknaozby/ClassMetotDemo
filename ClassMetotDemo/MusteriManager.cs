using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+musteri.Soyad+"Musteri Eklendi");
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id+"-)"+musteri.Ad+" "+musteri.Soyad+" - "+musteri.TCKN);
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" nolu Musteri Silindi ");
        }
    }
}
