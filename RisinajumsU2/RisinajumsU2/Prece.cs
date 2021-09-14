using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisinajumsU2
{
    class Prece
    {
        public Prece(string garums, string platums, string augstums)//preces izveidošana
        {
            Garums = garums;
            Platums = platums;
            Augstums = augstums;
        }
        double garums;
        public string Garums
        {
            get { return garums.ToString(); }
            private set { garums = double.Parse(value); }
        }

        double platums;
        public string Platums
        {
            get { return platums.ToString(); }
            private set { platums = double.Parse(value); }
        }

        double augstums;
        public string Augstums
        {
            get { return augstums.ToString();}
            private set { augstums = double.Parse(value); }
        }

        double svars;
        public string Svars
        {
            get { return svars.ToString(); }
            set { svars = double.Parse(value); }
        }


        public string PrecesDati()
        {
            return $"Garums: {garums}, Platums: {platums}, Augstums: {augstums}, Svars: {svars}";
        }


    }
}
