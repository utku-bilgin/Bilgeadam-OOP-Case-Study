using CSProjeDemo1_LibraryAutomationSystem.Enums;
using CSProjeDemo1_LibraryAutomationSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSProjeDemo1_LibraryAutomationSystem.Uyeler;

namespace CSProjeDemo1_LibraryAutomationSystem.Kutuphane
{
    public class Kutuphane
    {


        private Kitap tümKitaplar {  get; set; }

        public Kutuphane(Kitap kitap)
        {
            kitap.Kitaplar();
            this.tümKitaplar = kitap;
        }



        public List<Kitap> ÖdünçAlınanKitaplarıGörüntüle()
        {
            return tümKitaplar.ÖdünçAlınanKitaplar();
        }

        public List<Kitap> KütüphaneDurumunuGörüntüle()
        {
            return tümKitaplar.Kitaplar();
        }
    }
}
