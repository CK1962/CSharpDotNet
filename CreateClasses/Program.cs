using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCod
{
    class Program
    {
static void Main(string[] args)
        {
        }
    }
}
class DriverLicense
{

    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String Gender { get; set; }
    public String LicenseNumber { get; set; }

    public DriverLicense(string first_name, string last_name, string gender, string license_number)
    {
        FirstName = first_name;
        LastName = last_name;
        Gender = gender;
        LicenseNumber = license_number;

    }
    public String GetFullName()
    {
        return (FirstName + " " + LastName);
    }

    class Book
    {

        public String Title { get; set; }
        public String Author { get; set; }
        public String Pages { get; set; }
        public String SKU { get; set; }
        public String Pubisher { get; set; }
        public String Price { get; set; }

        public Book(string title, string author, string pages, string bar_code, string publisher, string price)
        {
            Title = title;
            Author = author;
            Pages = pages;
            SKU = bar_code;
            Pubisher = publisher;
            Price = Price;
        }
        class Airplane
        {

            public String Manufacturer { get; set; }
            public String Model { get; set; }
            public String Variant { get; set; }
            public String Capacity { get; set; }
            public String Engines { get; set; }

            public Airplane(string manufacturer, string model, string variant, string capacity, string engines)
            {
                Manufacturer = manufacturer;
                Model = model;
                Variant = variant;
                Capacity = capacity;
                Engines = engines;
            }
        }
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    Console.ReadLine();
}