using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal class Superhero : IFly, ITech, IStrength, ITelepathy
    {

        public string Alias {get; set;}
        public string SecretIdentity {get; set;}
        public int Age { get; set;}
        public Alignment Alignment {get; set;}

        //iFly
        public double FlightSpeed {get; set;}
        public double MaxHeight {get; set;}
        //IHack
        public string Gadget {get; set;}

        //IStrength
        public int StrengthLevel {get; set;}

        //iTelepathy
        public int PowerLevel {get; set;} 

        public void ReadMind(string alias)
        {
            Console.WriteLine(alias + " is reading your thoughts!");
        }

        public void Lift(string alias)
        {
            Console.WriteLine(alias + " lifts with all their might!");
        }

        public void Fly(string alias)
        {
            Console.WriteLine( alias + " swoops by, look at them go!");
        }

        public void Hack(string alias)
        {
            Console.WriteLine(alias + " is hacking into the mainframe!");
        }




        public Superhero(string alias, string secretIdentity, Alignment alignment, int age)
        {
            Alias = alias;
            SecretIdentity = secretIdentity;
            Age = age;
            Alignment = alignment;
        }


    }
}
