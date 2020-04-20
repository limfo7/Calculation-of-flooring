using System.Collections.Generic;

namespace Calculator.Wfa.DataLayer
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Coast1 { get; set; }
        public float CoastOpt { get; set; }

        public int MabufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public int CoverageTypeId { get; set; }
        public CoverageType CoverageType { get; set; }

        public List<Order> Order { get; set; }
    }
}
