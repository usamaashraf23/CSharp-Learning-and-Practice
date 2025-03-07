using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usama
{
    class Car
    {
        public string brand;
        public int model;
        public int year;

        public Car()
        {

        }
        public Car(string brand, int model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }
        public void StartEngine()
        {
            Console.WriteLine("This car is Starting");
        }
        public void Details()
        {
            Console.WriteLine($@"Brand={brand}
Model={model}
Year={year}");
        }
    }
}
