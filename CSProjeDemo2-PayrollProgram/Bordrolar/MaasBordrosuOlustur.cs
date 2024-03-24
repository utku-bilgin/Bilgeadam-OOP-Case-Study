using CSProjeDemo2_PayrollProgram.Personeller;
using CSProjeDemo2_PayrollProgram.Yardımlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSProjeDemo2_PayrollProgram.Bordrolar
{
    public class MaasBordrosuOlustur
    {
        public void BordroOlustur(List<Personel> personelListesi)
        {
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string yoneticiKlasorYolu = Path.Combine(masaustuYolu, "yöneticibordroları");
            Directory.CreateDirectory(yoneticiKlasorYolu);
            string memurKlasorYolu = Path.Combine(masaustuYolu, "memurbordroları");
            Directory.CreateDirectory(memurKlasorYolu);

            Console.WriteLine("-----------------------------------------------------------------------------------");
            GirilenYil girilenYil = new GirilenYil();
            string yilBilgisi = girilenYil.YilBilgisiAl();
            Console.WriteLine("");
            GirilenAy girilenAy = new GirilenAy();
            string ayBilgisi = girilenAy.AyBilgisiAl();
            Console.WriteLine("");



            if (personelListesi.Count != 0)
            {
                foreach (var personel in personelListesi)
                {
                    if (personel.Unvan == "Yonetici")
                    {
                        YoneticiBordrosu yoneticiBordrosu = new YoneticiBordrosu();
                        yoneticiBordrosu.YoneticiBordroOlustur(personel, yoneticiKlasorYolu, yilBilgisi, ayBilgisi);
                    }
                    else if (personel.Unvan == "Memur")
                    {
                        MemurBordrosu memurBordrosu = new MemurBordrosu();
                        memurBordrosu.MemurBordroOlustur(personel, memurKlasorYolu, yilBilgisi, ayBilgisi);
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        Console.WriteLine("Tanımsız personel unvanı: " + personel.Unvan);
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                    }
                }
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("Listede personel bulunmamaktadır");
                Console.WriteLine("-----------------------------------------------------------------------------------");
            }
        }
    }
}
