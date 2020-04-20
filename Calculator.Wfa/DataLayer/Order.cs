namespace Calculator.Wfa.DataLayer
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
