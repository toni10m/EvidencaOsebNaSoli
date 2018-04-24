using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Asistent : Oseba
    {
        public string Vaje { get; set; }

        public void vaje()
        {
            Console.WriteLine("Vaje: ");
            Vaje = Console.ReadLine();
        }
        public override void VnosOsebe()
        {
            base.VnosOsebe();
            vaje();
        }
        public override void IzpisPosamezneOsebe(Oseba oseba1)
        {
            base.IzpisPosamezneOsebe(oseba1);
            Asistent asist = (Asistent)oseba1;
            Console.WriteLine("Vloga: Asistent");
            Console.WriteLine("Vaje: " + asist.Vaje);
        }

        public override void SpreminjanjePosamezneOsebe(Oseba oseba1)
        {
            base.SpreminjanjePosamezneOsebe(oseba1);
            Asistent prof = (Asistent)oseba1;
            vaje();
        }

    }
}
