using CSProjeDemo2_PayrollProgram.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2_PayrollProgram.Yardımlar
{
    public class DemoPersonelListesi
    { 
        public void DemoPersonelListesiYazdır(List<Personel> personelListesi)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Demo Personel Listesi:");
            Console.WriteLine("");
            Console.WriteLine($"{"AD",-10} {"SOYAD",-10} ÜNVAN:");
            Console.WriteLine($"{"-----",-10} {"-----",-10} -----");
            foreach (Personel personel in personelListesi)
            {
                Console.WriteLine($"{personel.Ad,-10} {personel.Soyad,-10} {personel.Unvan}");
            }
            Console.WriteLine("");
        }
    }
}
