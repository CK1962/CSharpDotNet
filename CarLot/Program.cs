using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot cl1 = new CarLot();
            cl1.name = "Pollard";
            
            Truck t1 = new Truck();
            t1.licensePlate = "ABC123D";
            t1.make = "Ford";
            t1.model = "F150";
            t1.price = "$40,000";
            t1.bedSize = "XL";

            cl1.AddVehicle(t1);

            Truck t2 = new Truck();
            t2.licensePlate = "963PLM7";
            t2.make = "Ford";
            t2.model = "F250";
            t2.price = "$62,000";
            t2.bedSize = "XL";

            cl1.AddVehicle(t2);

            Car c1 = new Car();
            c1.licensePlate = "XYZ987A";
            c1.make = "Ford";
            c1.model = "Camry";
            c1.price = "$26,000";
            c1.type = "Compact";
            c1.numberOfDoors = 2;

            cl1.AddVehicle(c1);

            cl1.PrintInventory();

            CarLot cl2 = new CarLot();
            cl2.name = "Alderson";

            Truck tr2 = new Truck();
            tr2.licensePlate = "123GHJ4";
            tr2.make = "GMC";
            tr2.model = "Sierra";
            tr2.price = "$35,000";
            tr2.bedSize = "Standard";

            cl2.AddVehicle(tr2);

            Car c2 = new Car();
            c2.licensePlate = "456LKJ9";
            c2.make = "GMC";
            c2.model = "Acadia";
            c2.price = "$29,000";
            c2.type = "Sedan";
            c2.numberOfDoors = 4;

            cl2.AddVehicle(c2);

            Car c3 = new Car();
            c3.licensePlate = "DFG741K";
            c3.make = "GMC";
            c3.model = "Canyon";
            c3.price = "$33,000";
            c3.type = "Luxury";
            c3.numberOfDoors = 4;

            cl2.AddVehicle(c3);

            cl2.PrintInventory();

            Console.ReadLine();
        }
    }

    public class CarLot
    {
        public string name;
        public List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle v1)
        {
            vehicles.Add(v1);
        }

        public void PrintInventory()
        {
            Console.WriteLine($"{name}'s inventory: ");
            foreach(Vehicle v in vehicles)
            {
                string description = v.GetDescription();
                Console.WriteLine(description);
            }
            Console.WriteLine();
        }
    }

    public abstract class Vehicle
    {
        public string licensePlate;
        public string make;
        public string model;
        public string price;

        public abstract string GetDescription();
    }

    public class Truck : Vehicle
    {
        public string bedSize;

        public override string GetDescription()
        {
            return $"{base.licensePlate}; {base.make}; {base.model}; {base.price}; {this.bedSize}";
        }
    }

    public class Car : Vehicle
    {
        public string type;
        public int numberOfDoors;

        public override string GetDescription()
        {
            return $"{base.licensePlate}; {base.make}; {base.model}; {base.price}; {this.type}; {this.numberOfDoors}";
        }
    }
}

