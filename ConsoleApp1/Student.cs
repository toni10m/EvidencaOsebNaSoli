using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student : Oseba
    {
        public string Smer { get; set; }

        public void smer()
        {
            Console.WriteLine("Smer: ");
            Smer = Console.ReadLine();
        }

        public override void VnosOsebe()
        {
            base.VnosOsebe();
            smer();
        }
        public override void IzpisPosamezneOsebe(Oseba oseba1)
        {
            base.IzpisPosamezneOsebe(oseba1);
            Student stud = (Student)oseba1;
            Console.WriteLine("Vloga: Študent");
            Console.WriteLine("Smer: " + stud.Smer);
        }
        public override void SpreminjanjePosamezneOsebe(Oseba oseba1)
        {
            base.SpreminjanjePosamezneOsebe(oseba1);
            Student prof = (Student)oseba1;
            smer();
        }
    }
}
