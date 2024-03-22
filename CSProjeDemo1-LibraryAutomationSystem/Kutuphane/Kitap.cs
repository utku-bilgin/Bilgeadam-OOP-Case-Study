using CSProjeDemo1_LibraryAutomationSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1_LibraryAutomationSystem.Kutuphane
{
    public abstract class Kitap
    {
        public string ISBN { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public int YayinYili { get; set; }
        public Durum KitapDurumu { get; set; }
        public Kategori Kategori { get; set; }

        protected Kitap(string isbn, string baslik, string yazar, int yayinYili, Durum kitapDurumu, Kategori kategori)
        {
            ISBN = isbn;
            Baslik = baslik;
            Yazar = yazar;
            YayinYili = yayinYili;
            KitapDurumu = kitapDurumu;
        }

        protected List<KitapBilim> kitapBilims;
        protected List<KitapRoman> kitapRomans;
        protected List<KitapTarih> kitapTarihs;


        public List<Kitap> MevcutKitaplar { get; set; }

        public Kitap()
        {

            kitapBilims = new List<KitapBilim>();
            kitapRomans = new List<KitapRoman>();
            kitapTarihs = new List<KitapTarih>();


            KitapEkle(new KitapBilim("1234567890", "Bilim Kitabı 1", "Bilim Yazarı 1", 2020, Durum.OduncAlabilir, Kategori.Bilim), Kategori.Bilim);
            KitapEkle(new KitapBilim("2345678901", "Bilim Kitabı 2", "Bilim Yazarı 2", 2019, Durum.OduncAlabilir, Kategori.Bilim), Kategori.Bilim);
            KitapEkle(new KitapBilim("3456789012", "Bilim Kitabı 3", "Bilim Yazarı 3", 2018, Durum.OduncAlabilir, Kategori.Bilim), Kategori.Bilim);
            KitapEkle(new KitapRoman("4567890123", "Roman Kitabı 1", "Roman Yazarı 1", 2017, Durum.OduncAlabilir, Kategori.Roman), Kategori.Roman);
            KitapEkle(new KitapRoman("5678901234", "Roman Kitabı 2", "Roman Yazarı 2", 2016, Durum.OduncAlabilir, Kategori.Roman), Kategori.Roman);
            KitapEkle(new KitapRoman("6789012345", "Roman Kitabı 3", "Roman Yazarı 3", 2015, Durum.OduncAlabilir, Kategori.Roman), Kategori.Roman);
            KitapEkle(new KitapTarih("7890123456", "Tarih Kitabı 1", "Tarih Yazarı 1", 2014, Durum.OduncAlabilir, Kategori.Tarih), Kategori.Tarih);
            KitapEkle(new KitapTarih("8901234567", "Tarih Kitabı 2", "Tarih Yazarı 2", 2013, Durum.OduncAlabilir, Kategori.Tarih), Kategori.Tarih);
            KitapEkle(new KitapTarih("9012345678", "Tarih Kitabı 3", "Tarih Yazarı 3", 2012, Durum.OduncAlabilir, Kategori.Tarih), Kategori.Tarih);
        }

        public List<Kitap> Kitaplar()
        {
            List<Kitap> mevcutKitaplar = new List<Kitap>();

            if (kitapBilims != null)
            {
                foreach (var item in kitapBilims)
                {
                    mevcutKitaplar.Add(item);
                }
            }
            
            if (kitapRomans != null)
            {
                foreach (var item in kitapRomans)
                {
                    mevcutKitaplar.Add(item);
                }
            }
                
            if (kitapTarihs != null)
            {
                foreach (var item in kitapTarihs)
                {
                    mevcutKitaplar.Add(item);
                }
            }
            
            return mevcutKitaplar;
        }


        public void KitapEkle(Kitap kitap, Kategori kategori)
        {
            switch (kategori)
            {
                case Kategori.Bilim:
                    kitapBilims.Add((KitapBilim)kitap);
                    break;
                case Kategori.Roman:
                    kitapRomans.Add((KitapRoman)kitap);
                    break;
                case Kategori.Tarih:
                    kitapTarihs.Add((KitapTarih)kitap);
                    break;

                default:
                    break;
            }

            MevcutKitaplar.Add(kitap);
        }

        public void KitapDurumunuGüncelle(Kitap kitap, Durum durum)
        {

            int index = MevcutKitaplar.FindIndex(k => k.ISBN == kitap.ISBN);

            MevcutKitaplar[index].KitapDurumu = durum;
        }

        public List<Kitap> ÖdünçAlınanKitaplar()
        {
            return MevcutKitaplar.Where(kitap => kitap.KitapDurumu == Durum.OduncVerildi).ToList();
        }
    }
}
