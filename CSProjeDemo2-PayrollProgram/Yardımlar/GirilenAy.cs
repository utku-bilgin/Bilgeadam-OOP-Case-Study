using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2_PayrollProgram.Yardımlar
{
    public class GirilenAy
    {
        public string AyBilgisiAl()
        {
            string ayBilgisi;
            bool gecerliAy = false;

            do
            {
                Console.Write("Hangi aya ait bordroları oluşturuyorsunuz : ");
                ayBilgisi = Console.ReadLine();

                if (!GecerliAy(ayBilgisi))
                {
                    Console.WriteLine("");
                    Console.WriteLine($"{ayBilgisi} bir ay bilgisi değildir.");
                    Console.WriteLine("Geçerli bir ay giriniz !");
                }
                else
                {
                    gecerliAy = true;
                }
            } while (!gecerliAy);

            return ayBilgisi;
        }

        static bool GecerliAy(string ay)
        {
            string[] aylar = { "ocak", "şubat", "mart", "nisan", "mayıs", "haziran", "temmuz", "ağustos", "eylül", "ekim", "kasım", "aralık" };
            string kucukHarflerAy = ay.ToLower();

            foreach (string a in aylar)
            {
                if (kucukHarflerAy == a)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
