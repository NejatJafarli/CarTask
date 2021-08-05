using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsTask
{
    public class Car
    {
        public Car(string model, string vendor, int year, double engine,Image picture)
        {
            Model = model;
            Vendor = vendor;
            if (DateTime.Now.Year >= year)
                Year = year;
            Engine = engine;
            Picture = picture;
        }
        public Image Picture { get; set; }
        public string Model { get; set; }
        public string Vendor { get; set; }
        public int Year { get; set; }
        public double Engine { get; set; }
    }
}
