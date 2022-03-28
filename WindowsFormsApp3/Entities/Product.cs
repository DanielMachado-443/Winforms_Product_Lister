
namespace WindowsFormsApp3.Entities
{
    class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Product(int quantity)
        {
            Quantity = quantity;
        }

        public Product(double price)
        {
            Price = price;
        }

        public Product(string name)
        {
            Name = name;
        }

        public Product()
        {
            Price = 0.0;
            Name = "None";
            Quantity = 0;
        }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;           
            Quantity = quantity;
        }

        public double Sum()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return "==========================="
                + "\r\n   PRODUCT STATUS "
                + "\r\n \r\n   Name: "
                + Name
                + "\r\n   Price: $"
                + Price.ToString("F2")
                + "\r\n   Quantity: "
                + Quantity
                + "\r\n   Total: $" + this.Sum().ToString("F2")
                + "\r\n===========================";
        }
    }
}