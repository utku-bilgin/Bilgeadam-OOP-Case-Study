using CSProjeDemo2_PayrollProgram.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSProjeDemo2_PayrollProgram.Bordrolar
{
    public class MemurBordrosu
    {
        public void MemurBordroOlustur(Personel personel, string klasorYolu, string yilBilgisi, string ayBilgisi)
        {
            string memurIsmı = $"{personel.Ad} {personel.Soyad}";
            decimal memurCalismaSaati;
            decimal anaOdeme;
            decimal mesai;
            decimal toplamOdeme;

            Console.Write($"{personel.Ad} {personel.Soyad} memurun çalışma saati: ");
            memurCalismaSaati = Convert.ToDecimal(Console.ReadLine());

            Memur memur = new Memur();
            anaOdeme = memur.MaasHesapla(memurCalismaSaati);
            mesai = memur.EkUcretHesaplama(memurCalismaSaati);
            toplamOdeme = memur.AnaOdemeHesapla(memurCalismaSaati);

            var memurBordro = new MemurBordroEntity
            {
                PersonelIsmi = memurIsmı,
                CalismaSaati = memurCalismaSaati,
                AnaOdeme = anaOdeme,
                Mesai = mesai,
                ToplamOdeme = toplamOdeme
            };

            string dosyaYolu = Path.Combine(klasorYolu, $"{yilBilgisi}-{ayBilgisi}-{personel.Ad}{personel.Soyad}.json");
            string json = JsonSerializer.Serialize(memurBordro);
            File.WriteAllText(dosyaYolu, json);

            if (memurCalismaSaati < 10)
            {
                string raporDosyaYolu = Path.Combine(klasorYolu, $"YeterliCalismayanMemurlar.json");
                var calismayanMemur = new MemurBordroEntity
                {
                    PersonelIsmi = memurIsmı,
                    CalismaSaati = memurCalismaSaati,
                    AnaOdeme = anaOdeme,
                    Mesai = mesai,
                    ToplamOdeme = toplamOdeme
                };
                string json2 = JsonSerializer.Serialize(calismayanMemur);
                File.AppendAllText(raporDosyaYolu, json2 + Environment.NewLine);
            }
        }
    }
}
