namespace CSProjeDemo2_PayrollProgram.Personeller
{
    public abstract class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }

        public abstract decimal MaasHesapla(decimal CalismaSaati);
        public abstract decimal EkUcretHesaplama(decimal CalismaSaati);
        public abstract decimal AnaOdemeHesapla(decimal CalismaSaati);
    }
}
