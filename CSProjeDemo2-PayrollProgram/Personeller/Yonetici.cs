namespace CSProjeDemo2_PayrollProgram.Personeller
{
    public class Yonetici : Personel
    {

        public override decimal MaasHesapla(decimal CalismaSaati)
        {
            decimal saatlikUcreti = 700;
            decimal toplamOdeme;

            if (CalismaSaati > 180)
            {
                decimal normalMaas = 180 * saatlikUcreti;
                decimal bonusUcreti = (CalismaSaati - 180) * saatlikUcreti * 1.3m;
                toplamOdeme = normalMaas + bonusUcreti;
            }
            else
            {
                toplamOdeme = CalismaSaati * saatlikUcreti;
            }

            return toplamOdeme;
        }

        public override decimal EkUcretHesaplama(decimal CalismaSaati)
        {
            decimal saatlikUcreti = 700;
            decimal bonusUcreti;

            if (CalismaSaati > 180)
            {
                decimal normalMaas = 180 * saatlikUcreti;
                bonusUcreti = (CalismaSaati - 180) * saatlikUcreti * 1.3m;
            }
            else
            {
                bonusUcreti = 0;
            }
            return bonusUcreti;
        }

        public override decimal AnaOdemeHesapla(decimal CalismaSaati)
        {
            decimal saatlikUcreti = 700;
            decimal anaOdeme;

            if ((CalismaSaati > 180))
            {
                decimal normalMaas = (CalismaSaati - 180) * saatlikUcreti;
                anaOdeme = normalMaas;
            }
            else
            {
                decimal normalMaas = 180 * saatlikUcreti;
                anaOdeme = normalMaas;
            }
            return anaOdeme;
        }
    }
}
