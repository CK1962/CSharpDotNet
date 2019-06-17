using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person william = new Person ("William", "Bill");
            Person james = new Person ("James", "Jim");
            Person wade = new Person("Wade Turner", "Wade");

            Console.WriteLine("Hi, my name is {0}, you can call me {1}.", william.name, william.nickName);
            Console.WriteLine("Hi, my name is {0}, you can call me {1}.", james.name, james.nickName);

            SuperHero h1 = new SuperHero("Mr Incredible", "Super Strength");
        }
        public class Person
        {
            public string name { get; set; }
            public string nickName { get; set; }

            public Person(String iName, String iNickName)
            {
                this.name = iName;
                this.nickName = iNickName;

            }
        }

        class SuperHero : Person
        {
            public string heroName;
            public string superPower;

            public SuperHero(String iName, String iHeroName, String iSuperPower)
            {
                base.name = iName;
                this.heroName = iHeroName;
                this.superPower = iSuperPower;

                Console.WriteLine("I am {0}.  When I am {1}, my super power is {2}!", wade.name, h1.heroName, h1.superPower);
            }
        }

        class Villain : Person
        {
        public string nemesis;

            public Villain(String iNemesis, String iHeroName)
            {
                this.nemesis = iNemesis;
               
                Console.WriteLine("I am {0}!  Have you seen {1}?");
            }
        }
            
    }
}
