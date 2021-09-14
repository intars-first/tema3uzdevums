using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisinajumsU2
{
    class Persona
    {
        string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        int dzimsanasGads;
        public string DzimsanasGads
        {
            get { return dzimsanasGads.ToString(); }
            set { dzimsanasGads = int.Parse(value); }
        }

        public string Hobijs { get; set; }
        public string Dzimums { get; set; }

        int yearsOld;

        public void SavaVecumaAprekinasana()
        {
            yearsOld = 2021 - dzimsanasGads;
        }

        public string Sasveicinasanas()
        {
            return $"Hello my name is {name} {surname} and I am {yearsOld}";

        }
    }
}
