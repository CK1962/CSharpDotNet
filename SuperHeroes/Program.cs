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
            
        }
        public class Person
        {
            public string name;
            public string nickName;

            public Person(String iName, String iNickName)
            {
                this.name = iName;
                this.nickName = iNickName;

                Console.WriteLine("Hi, my name is {0}, you can call me {1}.");
            }
        }

        public class SuperHero
        {
            public string realName;
            public string superPower;

            public SuperHero(String iName, String iRealName, String iSuperPower)
            {
                base.name = iName;
                this.realName = iRealName;
                this.superPower = iSuperPower;

                Console.WriteLine("I am {0}.  When I am {1}, my super power is {2}!");
            }
        }

        class Villain
        {
        public string nemesis;

            public Villain(String iNickName, String iNemesis)
            {
                this.nemesis = iNemesis;

                Console.WriteLine("I am {0}!  Have you seen {1}?");
            }
        }
            
    }
}
