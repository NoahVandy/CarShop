using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    public class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public double price { get; set; }


        public Car(string make, string model, double price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
        }

        public Car()
        {
            this.make = "Nothing yet";
            this.model = "nothing yet";
            this.price = 0;
        }

        override
        public string ToString()
        {
            string newString = this.make + "| " + this.model + "| $" + this.price;
            return newString;
        }


    }


}

