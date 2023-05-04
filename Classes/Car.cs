using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public Car() // a special member method that has the same name as its class
        { 
            
        }

        public Car (string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }



        // Make proprty type string public
        // Model string public
        // Year int public
        public string Make { get; set; } // get = read, set = write
        public string Model { get; set; }

        public int Year { get; set; }
    }
}
