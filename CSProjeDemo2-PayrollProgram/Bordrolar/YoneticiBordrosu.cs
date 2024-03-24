using CSProjeDemo2_PayrollProgram.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSProjeDemo2_PayrollProgram.Bordrolar
{
    public class YoneticiBordrosu
    {
        public void YoneticiBordroOlustur(Personel personel, string klasorYolu, string yilBilgisi, string ayBilgisi)
        {
            string yoneticiIsmi = $"{personel.Ad} {personel.Soyad}";
            decimal yoneticiCalismaSaati;
            decimal anaOdeme;
            decimal bonus;
            decimal toplamOdeme;

            Console.Write($"{personel.Ad} {personel.Soyad} yöneticinin çalışma saati: ");
            yoneticiCalismaSaati = Convert.ToDecimal(Console.ReadLine());

            Yonetici yonetici = new Yonetici();
            anaOdeme = yonetici.AnaOdemeHesapla(yoneticiCalismaSaati);
            bonus = yonetici.EkUcretHesaplama(yoneticiCalismaSaati);
            toplamOdeme = yonetici.MaasHesapla(yoneticiCalismaSaati);

            var yoneticiBordro = new YoneticiBordroEntity
            {
                PersonelIsmi = yoneticiIsmi,
                CalismaSaati = yoneticiCalismaSaati,
                AnaOdeme = anaOdeme,
                Bonus = bonus,
                ToplamOdeme = toplamOdeme
            };

            string dosyaYolu = Path.Combine(klasorYolu, $"{yilBilgisi}-{ayBilgisi}-{personel.Ad}{personel.Soyad}.json");
            string json = JsonSerializer.Serialize(yoneticiBordro);
            File.WriteAllText(dosyaYolu, json);

            if (yoneticiCalismaSaati < 10)
            {
                string raporDosyaYolu = Path.Combine(klasorYolu, $"YeterliCalismayanMemurlar.json");
                var calismayanYonetici = new YoneticiBordroEntity
                {
                    PersonelIsmi = yoneticiIsmi,
                    CalismaSaati = yoneticiCalismaSaati,
                    AnaOdeme = anaOdeme,
                    Bonus = bonus,
                    ToplamOdeme = toplamOdeme
                };
                string json2 = JsonSerializer.Serialize(calismayanYonetici);
                File.AppendAllText(raporDosyaYolu, json2 + Environment.NewLine);
            }
        }
    }
}
