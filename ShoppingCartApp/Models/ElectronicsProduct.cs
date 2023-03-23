using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Models
{
    public class ElectronicsProduct : Product
  {
    private readonly string Brand;
    private readonly string Model;
    public ElectronicsProduct(string name, double price, string brand, string model) : base(name, price, ProductCategory.Electronics)
    {
      this.Brand = brand;
      this.Model = model;
    }

    public override void GetInfo()
    {
      base.GetInfo();
      Console.WriteLine($"Brand: {Brand}\nModel: {Model}");
      }
  }
}
