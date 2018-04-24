using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Oseba
    {
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public int Starost { get; set; }
        public string Naslov { get; set; }

        public virtual void VnosOsebe()
        {
            Console.WriteLine("Ime:");
            Ime = Console.ReadLine();
            Console.WriteLine("Priimek:");
            Priimek = Console.ReadLine();
            Console.WriteLine("Starost:");
            string starost1 = Console.ReadLine();
            if (Int32.TryParse(starost1, out int starost))
            {
                Starost = starost;
            }
            Console.WriteLine("Naslov: ");
            Naslov = Console.ReadLine();

        }
        public virtual void IzpisPosamezneOsebe(Oseba oseba1)
        {
            Console.WriteLine("Ime: " + oseba1.Ime);
            Console.WriteLine("Priimek: " + oseba1.Priimek);
            Console.WriteLine("Starost: " + oseba1.Starost);
            Console.WriteLine("Naslov: " + oseba1.Naslov);
        }
        public virtual void SpreminjanjePosamezneOsebe(Oseba oseba1)
        {
          
        }
        
    }
}
