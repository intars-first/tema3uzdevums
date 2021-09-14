using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisinajumsU2
{
    class Masina
    {
        public string Marka { get; set; }
        public string NumurZime { get; set; }

        double atrums;
        public string Atrums
        {
            get
            {
                return atrums.ToString();
            }
            set
            {
                atrums = double.Parse(value);
            }
        }

        public void UzsaktBraukt() { }
        public void PalielinatAtrumu() { }
        public void BeigtBraukt() { }
        public string Uztauret()
        {
            return "Beep beep";
        }

    }
}
