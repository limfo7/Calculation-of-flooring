using System.Collections.Generic;

namespace Calculator.Wfa.DataLayer
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        public string Name { get; set; }

        public List<Product> Product { get; set; }
    }
}
