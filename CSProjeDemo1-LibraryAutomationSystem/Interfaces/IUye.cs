using CSProjeDemo1_LibraryAutomationSystem.Kutuphane;
using CSProjeDemo1_LibraryAutomationSystem.Kutuphane;
using CSProjeDemo1_LibraryAutomationSystem.Uyeler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1_LibraryAutomationSystem.Interfaces
{
    public interface IUye
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        int UyeNo { get; set; }
        List<Kitap> OduncKitaplar { get; set; }

        void KitapÖdünçAl(Kitap kitap);
        void KitapİadeEt(Kitap kitap);
        void UyeEkle(Uye uye);
    }
}
