using System;

namespace RisinajumsU2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============Telefons============");
            var telefons = new Telefons();

            Console.Write("Marka? ");
            telefons.Marka=Console.ReadLine();
            Console.Write("Modelis? ");
            telefons.Modelis = Console.ReadLine();
            Console.Write("Garums? ");
            telefons.Garums = Console.ReadLine();
            Console.Write("Platums? ");
            telefons.Platums = Console.ReadLine();
            Console.Write("Augstums? ");
            telefons.Augstums = Console.ReadLine();

            Console.WriteLine("\n=============Mašīna============");

            var masina = new Masina();
            Console.Write("Marka? ");
            masina.Marka = Console.ReadLine();
            Console.Write("Numurzīme? ");
            masina.NumurZime = Console.ReadLine();
            Console.Write("Ātrums? ");
            masina.Atrums = Console.ReadLine();

            Console.WriteLine(masina.Uztauret());

            Console.WriteLine("\n=============Prece=============");

            Console.WriteLine("Ievadiet garumu, platumu un augstumu!");
            var prece = new Prece(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Console.Write(".. un svaru! ");
            prece.Svars = Console.ReadLine();
             
            Console.WriteLine(prece.PrecesDati());

            Console.WriteLine("\n=============Persona===========");

            var persona = new Persona();
            Console.Write("Vards? ");
            persona.Name = Console.ReadLine();
            Console.Write("Uzvārds? ");
            persona.Surname = Console.ReadLine();

            Console.Write("Dzimšanas gads? ");
            persona.DzimsanasGads = Console.ReadLine();

            Console.Write("Hobijs? ");
            persona.Hobijs = Console.ReadLine();
            Console.Write("Dzimums? ");
            persona.Dzimums = Console.ReadLine();

            persona.SavaVecumaAprekinasana();

            Console.WriteLine(persona .Sasveicinasanas());


        }
    }
}
