using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisinajumsU2
{
    class Telefons
    {
        public string Marka { get; set; }
        public string Modelis { get; set; }

        double garums;
        public string Garums
        {
            get
            {
                return garums.ToString();
            }
            set
            {
                garums = double.Parse(value);
            }
        }
        double platums;
        public string Platums
        {
            get
            {
                return garums.ToString();
            }
            set
            {
                garums = double.Parse(value);
            }
        }
        double augstums;
        public string Augstums
        {
            get
            {
                return garums.ToString();
            }
            set
            {
                garums = double.Parse(value);
            }
        }

        public void Zvanit() { }

        public void SutitSMS() { }
    }
}
