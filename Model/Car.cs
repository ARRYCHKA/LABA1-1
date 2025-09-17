using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace L1
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        

        public Car(string brand, string model, string color)
        {
            Brand  = brand;
            Model = model;
            Color = color;
            
        }        
    }
}
