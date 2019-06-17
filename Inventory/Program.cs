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
           
            Car c1 = new Car();
            c1.licensePlate = "XYZ987A";
            c1.make = "Ford";
            c1.model = "Camry";
            c1.price = "$26,000";
            c1.type = "Compact";
            c1.numberOfDoors = 2;

            cl1.AddVehicle(c1);

            cl1.PrintInventory();


        }

        public List<IRentable> rentables = new List<IRentable>();
    }

    public interface IRentable
    {
        public GetDailyRate()
        {
            return "";
        }
        public GetDescription()
        {
            return "";
        }
    }

    public class Boat : IRentable
    {
        public string hourlyRate;
    }

    public class House : IRentable
    {
        public string weeklyRate;
    }

    public class Car : IRentable
    {
        public string dailyRate;
    }
}
