using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> rentables = new List<IRentable>();

            Car r1 = new Car("car");
            rentables.Add(r1);

            Boat r2 = new Boat("boat");
            rentables.Add(r2);

            House r3 = new House("house");
            rentables.Add(r3);

            foreach(IRentable r in rentables)
            {
                Console.WriteLine(r.GetDescription());
                Console.WriteLine(r.GetDailyRate());
                Console.WriteLine(r.GetType());
            }
            

            Console.ReadLine();
        }
    }

    interface IRentable
    {
        decimal GetDailyRate();
        string GetDescription();
    }

    public class Boat : IRentable
    {
        private decimal _hourlyRate = 12.5m;
        private string _description { get; set; }
        public Boat(string description)
        {
            _description = description;
        }

        public decimal GetDailyRate()
        {
            return Decimal.Round( _hourlyRate * 24, 2);
        }

        public string GetDescription()
        {
            return _description;
        }
    }

    public class House : IRentable
    {
        private decimal _weeklyRate = 510.5m;
        public string _description { get; set; }
        public House(string description)
        {
            _description = description;
        }

        public decimal GetDailyRate()
        {
            return Decimal.Round(_weeklyRate / 7, 2);
        }
        public string GetDescription()
        {
            return _description;
        }
    }
    public class Car : IRentable
    {
        private decimal _dailyRate = 35.5m;
        public string _description { get; set; }
        public Car(string description)
        {
            _description = description;
        }

        public decimal GetDailyRate()
        {
            return Decimal.Round(_dailyRate, 2);
        }
        public string GetDescription()
        {
            return _description;
        }
    }
}
