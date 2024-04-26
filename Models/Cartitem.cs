namespace WebLongChau.Models
{
    public class Cartitem
    {
        public int ProductId {  get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string ProductIamge { get; set; }
        public int Quantity { get; set; }
        public int Amount => Quantity * Price;
    }
}
