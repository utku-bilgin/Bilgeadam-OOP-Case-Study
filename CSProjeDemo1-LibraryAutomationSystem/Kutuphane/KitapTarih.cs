using CSProjeDemo1_LibraryAutomationSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1_LibraryAutomationSystem.Kutuphane
{
    public class KitapTarih : Kitap
    {
        public KitapTarih(string isbn, string baslik, string yazar, int yayinYili, Durum kitapDurumu, Kategori kategori) : base(isbn, baslik, yazar, yayinYili, kitapDurumu, kategori)
        {
            ISBN = isbn;
            Baslik = baslik;
            Yazar = yazar;
            YayinYili = yayinYili;
            KitapDurumu = kitapDurumu;
            Kategori = kategori;
        }
    }
}
