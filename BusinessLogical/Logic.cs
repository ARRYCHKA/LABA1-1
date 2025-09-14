using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public class Logic
    {
        List<Car> Cars = new List<Car>();
        public void AddCar(string carBrand, string carModel, string carColor)
        {
            Car car = new Car()
            {
                Brand = carBrand,
                Model = carModel,
                Color = carColor
            };
            Cars.Add(car);              

        }
        public string GetAll()
        {
            string s = string.Empty;
            foreach (Car car in Cars)
            {
                s += car.Brand + "" + car.Model + "" + car.Color;
            }
            return s;
        }
    }
}
