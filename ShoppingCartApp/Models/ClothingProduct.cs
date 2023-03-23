using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Models
{
    public class ClothingProduct : Product
  {
    private string Size;
    private string Colour;
    public ClothingProduct(string name, double price, string size, string colour) : base(name, price, ProductCategory.Clothing)
    {
      this.Size = size;
      this.Colour = colour;
    }

    public override void GetInfo()
    {
      base.GetInfo();
            Console.WriteLine($"Size: {Size}\nColour: {Colour}");
    }
  }
}
