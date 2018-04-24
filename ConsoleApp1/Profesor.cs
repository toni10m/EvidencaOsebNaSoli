using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Profesor : Oseba
    {
        public string Predava { get; set; }

        public void predava(){
            Console.WriteLine("Predava: ");
            Predava = Console.ReadLine();
        }
        public override void VnosOsebe()
        {
            base.VnosOsebe();
            predava();
        }
        public override void IzpisPosamezneOsebe(Oseba oseba1)
        {
            base.IzpisPosamezneOsebe(oseba1);
            Profesor prof = (Profesor)oseba1;
            Console.WriteLine("Vloga: Profesor");
            Console.WriteLine("Predava: " + prof.Predava);
        }
        public override void SpreminjanjePosamezneOsebe(Oseba oseba1)
        {
            base.SpreminjanjePosamezneOsebe(oseba1);
            Profesor prof = (Profesor)oseba1;
            predava();
        }

    }
}
