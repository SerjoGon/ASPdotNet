namespace Angulyr_ASP.Models
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;  
        public decimal Price { get; set; }    
        public  static Product[] GetProducts()
        {
            Product board = new Product() { 
                Name = "Board", Price = 300
            }; 
            Product ball = new Product() { 
                Name = "Ball", Price = 50
            };
            return new Product[] { board, ball };
        }
    }
}
