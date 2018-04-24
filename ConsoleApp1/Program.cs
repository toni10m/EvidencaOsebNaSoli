using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static List<Oseba> seznamOseb = new List<Oseba>();
        static void Main(string[] args)
        {
            menu();
        }
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("Za izbor željene funkcionalnosti vtipkajte številko pred le to!");
            Console.WriteLine("\n1-Seznam oseb");
            Console.WriteLine("2-Dodajanje osebe");
            Console.WriteLine("3-Izpis posamezne osebe po index-u");
            Console.WriteLine("4-Sprememba podatkov osebe");
            Console.WriteLine("5-Izbris osebe po priimku ali index-u");
            Console.WriteLine("6-Izhod");
            string n = Console.ReadLine();
            Console.Clear();
            switch (n)
            {
                case "1":
                    izpisSeznama();
                    break;
                case "2":
                    dodajanjeOsebe();
                    break;
                case "3":
                    izpisOsebe();
                    break;
                case "4":
                    spreminjanjeOsebe();
                    break;
                case "5":
                    izbrisOsebe();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    menu();
                    break;
            }
            menu();
        }
        public static void dodajanjeOsebe()
        {
            Console.WriteLine("Izberite vlogo osebe:\n1-Profesor\n2-Asistent\n3-Študent\nKarkoli drugega-Izhod v glavni menu");
            string n = Console.ReadLine();
            if (n == "1")
            {
                Profesor profesor1 = new Profesor();
                profesor1.VnosOsebe();
                seznamOseb.Add(profesor1);
            }else if (n == "2")
            {
                Asistent asistent1 = new Asistent();
                asistent1.VnosOsebe();
                seznamOseb.Add(asistent1);
            }else if (n == "3")
            {
                Student student1 = new Student();
                student1.VnosOsebe();
                seznamOseb.Add(student1);
            }
        }
        public static void izpisSeznama()
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0,-5}{1,-15}{2,-15}{3,-10}{4,-20}{5,-15}{6, -20}", "ID", "Ime", "Priimek", "Starost", "Naslov", "Vloga", "Predava/Smer/Vaje"));
            string vloga = "";
            for (int i = 0; i < seznamOseb.Count; i++)
            {
                string polje = "";
                if (seznamOseb[i] is Profesor prof)
                {
                    polje = prof.Predava;
                    vloga = "Profesor";
                }
                else if (seznamOseb[i] is Asistent asist)
                {
                    polje = asist.Vaje;
                    vloga = "Asistent";
                }
                else if (seznamOseb[i] is Student stud)
                {
                    polje = stud.Smer;
                    vloga = "Študent";
                }
                Console.WriteLine(String.Format("{0,-5}{1,-15}{2,-15}{3,-10}{4,-20}{5,-15}{6,-20}", i, seznamOseb[i].Ime, seznamOseb[i].Priimek, seznamOseb[i].Starost, seznamOseb[i].Naslov, vloga, polje));
            }
            Console.ReadLine();
        }
        public static void izbrisOsebe()
        {
            Console.WriteLine("Vnesite način brisanja, ki ga želite izvesti:\n1-Po index-u\n2-Po priimku\nKarkoli drugega-Izhod v glavni menu");
            string index = Console.ReadLine();
            izpisSeznama();
            if (index == "1")
            {
                Console.WriteLine("Vnesite index izbrane osebe:");
                string izbor = Console.ReadLine();

                if (Int32.TryParse(izbor, out int izbor1) && izbor1 < seznamOseb.Count)
                {
                    seznamOseb.RemoveAt(izbor1);
                }
                else
                {
                    Console.WriteLine("Index-a, ki ste ga vnesli ni v seznamu oseb!");
                    Console.ReadLine();
                    izbrisOsebe();
                }
            }
            else if (index == "2")
            {
                Console.WriteLine("Vnesite priimek izbrane osebe:");
                string izbor = Console.ReadLine();
                if (seznamOseb.Exists(x => x.Priimek.ToLower() == izbor))
                {
                    seznamOseb.RemoveAll(x => x.Priimek.ToLower() == izbor);
                }
                else
                {
                    Console.WriteLine("Oseba s tem priimkom ne obstaja");
                    Console.ReadLine();
                    izbrisOsebe();
                }
            }
        }
        public static void izpisOsebe()
        {
            izpisSeznama();
            Console.WriteLine("Vnesite index izbrane osebe:");
            string izbor = Console.ReadLine();
            int izbor1;
            if (Int32.TryParse(izbor, out izbor1) && izbor1 < seznamOseb.Count)
            {
                if (seznamOseb[izbor1] is Profesor prof)
                {
                    prof.IzpisPosamezneOsebe(seznamOseb[izbor1]);
                }
                else if (seznamOseb[izbor1] is Asistent asist)
                {
                    asist.IzpisPosamezneOsebe(seznamOseb[izbor1]);
                }
                else if (seznamOseb[izbor1] is Student stud)
                {
                    stud.IzpisPosamezneOsebe(seznamOseb[izbor1]);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ta index ne obstaja");
                Console.ReadLine();
            }
        }
        public static void spreminjanjeOsebe()
        {
            izpisSeznama();
            Console.WriteLine("Vnesite index izbrane osebe:");
            string izbor = Console.ReadLine();
            int izbor1;
            if (Int32.TryParse(izbor, out izbor1) && izbor1 < seznamOseb.Count && izbor1 >= 0)
            {
                if (seznamOseb[izbor1] is Profesor prof)
                {
                    prof.IzpisPosamezneOsebe(seznamOseb[izbor1]);
                    prof.SpreminjanjePosamezneOsebe(seznamOseb[izbor1]);
                }
                else if (seznamOseb[izbor1] is Asistent asist)
                {
                    asist.IzpisPosamezneOsebe(seznamOseb[izbor1]);
                    asist.SpreminjanjePosamezneOsebe(seznamOseb[izbor1]);
                }
                else if (seznamOseb[izbor1] is Student stud)
                {
                    stud.IzpisPosamezneOsebe(seznamOseb[izbor1]);
                    stud.SpreminjanjePosamezneOsebe(seznamOseb[izbor1]);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ta index ne obstaja");
                Console.WriteLine("1-Ponoven poizkus spreminjanja osebe\nKarkoli drugega-Izhod v glavni menu");
                string n = Console.ReadLine();
                if (n == "1")
                {
                    spreminjanjeOsebe();
                }
                else
                {
                    menu();
                }
            }
            
        }
    }
}

