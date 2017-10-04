using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator
{
    public class Sumator
    {
        public Sumator(decimal limit, decimal suma = 0)
        {
            this.Suma = suma;
            this.Limit = limit;
        }

        public decimal Limit { get; private set; }
        public decimal Suma { get; set; }

        public bool CzyKwotaJestPoprawna(decimal kwota)
        {
            bool czyDodatnia = kwota > 0;
            bool czyPrzekroczyLimit = Suma + kwota > Limit;
            return czyDodatnia && !czyPrzekroczyLimit;
        }

        public void Dodaj(decimal kwota)
        {
            if (!CzyKwotaJestPoprawna(kwota))
                throw new ArgumentOutOfRangeException("Kwota za duża lub ujemna");
            Suma += kwota;
        }
    }
}
