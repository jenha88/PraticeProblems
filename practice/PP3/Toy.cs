using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP3
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        private string Aisle;

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Image = "";
            Aisle = "";
        }

        public string GetAisle()
        {
            return $"{Manufacturer[0].ToString().ToUpper()}{Price}";
        }

        public override string ToString()
     
        {
            return $"{Manufacturer}- {Name}";
        }
    }
}
