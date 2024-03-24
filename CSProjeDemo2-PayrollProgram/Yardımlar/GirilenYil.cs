using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2_PayrollProgram.Yardımlar
{
    public class GirilenYil
    {
        public string YilBilgisiAl()
        {
            string yilBilgisi;
            bool gecerliYil = false;

            do
            {
                Console.WriteLine("");
                Console.Write("Hangi yıla ait bordroları oluşturuyorsunuz : ");
                yilBilgisi = Console.ReadLine();

                if (!SayiMi(yilBilgisi) || yilBilgisi.Length != 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"{yilBilgisi} bir yıl bilgisi değildir !");
                    Console.WriteLine("Geçerli bir yıl giriniz !");
                }
                else
                {
                    gecerliYil = true;
                }
            } while (!gecerliYil);

            return yilBilgisi;
        }

        private bool SayiMi(string value)
        {
            foreach (char item in value)
            {
                if (!char.IsDigit(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
