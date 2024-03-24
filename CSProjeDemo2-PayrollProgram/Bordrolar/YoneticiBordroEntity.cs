using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2_PayrollProgram.Bordrolar
{
    public class YoneticiBordroEntity
    {
        public string PersonelIsmi { get; set; }
        public decimal CalismaSaati { get; set; }
        public decimal AnaOdeme { get; set; }
        public decimal Bonus { get; set; }
        public decimal ToplamOdeme { get; set; }
    }
}
