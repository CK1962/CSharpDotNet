using System;
using System.Collections.Generic;

namespace SuperHeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> humans = new List<Person>();

            Person william = new Person("William Smith", "Bill");
            humans.Add(william);

            SuperHero wade = new SuperHero("Wade Turner", "Mr. Incredible", "super strength");
            humans.Add(wade);

            Villain joker = new Villain("Jack Napier", "The Joker", "Batman");
            humans.Add(joker);

            foreach (Person human in humans)
            {
                Console.Write($"{human.Name}: ");
                human.PrintGreeting();
            }

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string NickName { get; set; }

        public Person(string name, string nickName)
        {
            Name = name;
            NickName = nickName;
        }

        public virtual void PrintGreeting()
        {
            Console.WriteLine($"Hi, my name is {Name}, you can call me {NickName}.");
        }
    }

    public class SuperHero : Person
    {
        public string HeroName;
        public string SuperPower;

        public SuperHero(string name, string heroName, string superPower) : base(name, null)
        {
            this.HeroName = heroName;
            this.SuperPower = superPower;
        }

        public override void PrintGreeting()
        {
            Console.WriteLine($"My name is {base.Name}. When I am {HeroName}, my superpower is {SuperPower}.");
        }
    }

    public class Villain : Person
    {
        public string VillainName;
        public string Nemesis;

        public Villain(string name, string villainName, string nemesis) : base(name, null)
        {
            this.VillainName = villainName;
            this.Nemesis = nemesis;
        }

        public override void PrintGreeting()
        {
            Console.WriteLine($"I am {this.VillainName}!  Have you seen {this.Nemesis}?");
        }
    }
}