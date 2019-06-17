using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeros2
{
    class MainClass
    {
        class Person
        {
            public string name;
            public string nickName;
            public void PrintGreeting()
            {
                Console.WriteLine("Hi, my name is " + p1.name + "you can call me" + p1.nickName.);
            }
        }
        class SuperHero : Person
        {
            public string heroName;
            public string superpower;

            public void Hero()
            {
                Console.WriteLine("I am {0}. When I am {2}, my super power is {3}!");
            }
        }
        class Villain : Person
        {
            public string nemesis;

            public void Versus()
            {
                Console.WriteLine("I am {5}! Have you seen {3}?");
            }
        }
        public static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.name = "William Smith";
            p1.nickName = "Bill";

            SuperHero s1 = new SuperHero();
            s1.name = "Wade Turner";
            s1.heroName = "Mr Incredible";
            s1.superpower = "Super Strength";

            Villain v1 = new Villain();
            v1.name = "The Joker";
            v1.nemesis = "Batman";

            Console.ReadKey();

        }
    }
}
