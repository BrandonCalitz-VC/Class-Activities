namespace ShoppingCartApp.Models
{
    public class Product
    {
      public string Name { get; set; }
      public double Price { get; set; }
      private ProductCategory Category { get; set; }

      public Product(string name, double price, ProductCategory category)
      {
          this.Name = name;
          this.Price = price;
          this.Category = category;
      }

      public virtual void GetInfo()
      {
          Console.WriteLine($"Name: {Name}\nPrice: {Price}\nCategory: {Category}");
      }


    }
}
