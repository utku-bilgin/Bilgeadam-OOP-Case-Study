using CSProjeDemo1_LibraryAutomationSystem.Enums;
using CSProjeDemo1_LibraryAutomationSystem.Interfaces;
using CSProjeDemo1_LibraryAutomationSystem.Kutuphane;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1_LibraryAutomationSystem.Uyeler
{
    public class Uye : IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNo { get; set; }

        public Uye(string ad, string soyad, int uyeNo)
        {
            Ad = ad;
            Soyad = soyad;
            UyeNo = uyeNo;
        }

        private Kitap tümKitaplar { get; set; }

        public Uye(Kitap kitap)
        {
            kitap.Kitaplar();
            this.tümKitaplar = kitap;
        }

        public Uye()
        {
            UyeEkle(new Uye("Ahmet", "Yılmaz", 1001));
            UyeEkle(new Uye("Ayşe", "Kara", 1002));
        }

        public List<IUye> Uyeler { get; set; }

        public List<Kitap> OduncKitaplar { get; set; }



        public void KitapÖdünçAl(Kitap kitap)
        {
            if (kitap.KitapDurumu == Durum.OduncAlabilir)
            {
                OduncKitaplar.Add(kitap);
                tümKitaplar.KitapDurumunuGüncelle(kitap, Durum.OduncVerildi);
            }
            else
            {
                Console.WriteLine("Bu kitap ödünç alınamaz.");
            }
        }

        public void KitapİadeEt(Kitap kitap)
        {
            int index = OduncKitaplar.FindIndex(k => k.ISBN == kitap.ISBN);

            OduncKitaplar.Remove(kitap);
            tümKitaplar.KitapDurumu = Durum.OduncAlabilir;
        }

        public void UyeEkle(Uye uye)
        {
            Uyeler.Add(uye);
        }


    }
}
