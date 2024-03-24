using CSProjeDemo2_PayrollProgram.Personeller;
using System.Text.Json;

namespace CSProjeDemo2_PayrollProgram.Yardımlar
{
    public class PersonelJson
    {
        public string Name { get; set; }
        public string Title { get; set; }
    }

    public class Root
    {
        public List<PersonelJson> Personeller { get; set; }
    }

    public class DosyaOku
    {
        public List<Personel> Oku(string dosyaYolu)
        {
            List<Personel> personelListesi = new List<Personel>();
           
            string json = File.ReadAllText(dosyaYolu);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var data = JsonSerializer.Deserialize<Root>(json, options).Personeller;

            foreach (var item in data)
            {
                string[] isimParcala = item.Name.Split(" ");
                string ad = string.Join(" ", isimParcala.Take(isimParcala.Length - 1));
                string soyad = isimParcala.Last();

                if (item.Title.ToLower() == "yonetici")

                {
                    personelListesi.Add(new Yonetici { Ad = ad, Soyad = soyad, Unvan = item.Title });
                }
                else if (item.Title.ToLower() == "memur")
                {
                    personelListesi.Add(new Memur { Ad = ad, Soyad = soyad, Unvan = item.Title });
                }
            }

            return personelListesi;
        }
    }

}

