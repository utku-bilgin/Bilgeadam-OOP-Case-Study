namespace CSProjeDemo2_PayrollProgram.Personeller
{
    public class Memur : Personel
    {

        public override decimal MaasHesapla(decimal CalismaSaati)
        {
            decimal saatlikUcreti = 500;
            decimal toplamOdeme;

            if (CalismaSaati > 180)
            {
                decimal normalMaas = 180 * saatlikUcreti;
                decimal ekMesaiUcreti = (CalismaSaati - 180) * saatlikUcreti * 1.5m;
                toplamOdeme = normalMaas + ekMesaiUcreti;
            }
            else
            {
                toplamOdeme = CalismaSaati * saatlikUcreti;
            }

            return toplamOdeme;
        }

        public override decimal EkUcretHesaplama(decimal CalismaSaati)
        {
            decimal saatlikUcreti = 500;
            decimal ekMesaiUcreti;

            if (CalismaSaati > 180)
            {
                decimal normalMaas = 180 * saatlikUcreti;
                ekMesaiUcreti = (CalismaSaati - 180) * saatlikUcreti * 1.5m;
            }
            else
            {
                ekMesaiUcreti = 0;
            }
            return ekMesaiUcreti;
        }

        public override decimal AnaOdemeHesapla(decimal CalismaSaati)
        {
            decimal saatlikUcreti = 500;
            decimal anaOdeme;

            if ((CalismaSaati > 180))
            {
                decimal normalMaas = (CalismaSaati-180) * saatlikUcreti;
                anaOdeme = normalMaas;
            }
            else
            {
                decimal normalMaas = 180 * saatlikUcreti;
                anaOdeme= normalMaas;
            }
            return anaOdeme;
        }


    }
}
