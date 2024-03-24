using CSProjeDemo2_PayrollProgram.Bordrolar;
using CSProjeDemo2_PayrollProgram.Personeller;
using CSProjeDemo2_PayrollProgram.Yardımlar;


DosyaOku dosyaOku = new DosyaOku();
string projeKlasorYolu = AppDomain.CurrentDomain.BaseDirectory;
string demoPersoneller = Path.Combine(projeKlasorYolu, "personeller.json");
List<Personel> personelListesi = dosyaOku.Oku(demoPersoneller);
DemoPersonelListesi demoPersonelListesi = new DemoPersonelListesi();
demoPersonelListesi.DemoPersonelListesiYazdır(personelListesi);


Console.WriteLine("-----------------------------------------------------------------------------------");
Console.WriteLine("");
Console.Write("Demo personel listesi ile devam etmek için 1 kendi json dosyanız ile devam etmek için 2 tuşlayın : ");
string secim = Console.ReadLine();
if (secim == "2")
{
    Console.WriteLine("");
    Console.Write("Patch adresini yazın : ");
    string path = Console.ReadLine();
    Console.WriteLine("");
    if (path.StartsWith("\"") && path.EndsWith("\""))
    {
        path = path.Substring(1, path.Length - 2);
    }
    string kullanıcınınDosyası = Path.Combine(path);
    personelListesi = dosyaOku.Oku(kullanıcınınDosyası);
}
else if (secim == "1")
{

}
else
{
    Console.WriteLine("");
    Console.WriteLine("Geçerli bir seçenek girin !");
}


Console.WriteLine("-----------------------------------------------------------------------------------");
Console.WriteLine("");
Console.Write("Bordroların oluşturulması için onaylayın : ");
Console.ReadLine();
Console.WriteLine("");

MaasBordrosuOlustur maasBordrosuOlustur = new MaasBordrosuOlustur();
maasBordrosuOlustur.BordroOlustur(personelListesi);

Console.WriteLine("-----------------------------------------------------------------------------------");
Console.WriteLine("Bordrolar masaüstünde Yönetici ve Memur olarak ayrı klasörlerde oluşturuldu");
Console.WriteLine("-----------------------------------------------------------------------------------");
Console.ReadLine();

