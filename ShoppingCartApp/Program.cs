using ShoppingCartApp.Models;
using System.Threading.Channels;

namespace ShoppingCartApp
{
  public class Program
  {
    public static List<Product> shelve = new List<Product>();
    static void Main(string[] args) {
      shelve.Add(new ElectronicsProduct("Phone", 12.4, "Samsang", "S40"));
      shelve.Add(new ElectronicsProduct("laptop", 23, "Acer", "Aspire 2"));
      shelve.Add(new ClothingProduct("Shirt", 5.2, "Large", "Black"));
      shelve.Add(new ClothingProduct("Pants", 10, "Small", "White"));
      shelve.Add(new Product("Apple", 1.1, ProductCategory.Groceries));

      Console.WriteLine("Available Products:");
      shelve.ForEach(x => Console.WriteLine(x.Name));

      Console.WriteLine("\n\nPlease Enter the name of the product you want to add. Enter nothing to complete order!!");
      ShoppingCart cart = new ShoppingCart();
      while (true)
      {
        string inP = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(inP)) { break; }
        Product? product = shelve.Find(x => x.Name.Equals(inP));
        if (product != null)
        {
          cart.AddProduct(product);
        }
      }
      
      cart.GetProducts().ForEach(x => x.GetInfo());
      double sum = 0;
      cart.GetProducts().ForEach(x => sum += x.Price);
            Console.WriteLine($"Total: ${sum}");
        }
  }
}
