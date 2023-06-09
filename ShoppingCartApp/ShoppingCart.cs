﻿using ShoppingCartApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
  public class ShoppingCart
  {
    private List<Product> products = new List<Product>();


    public void AddProduct(Product product)
    {
      products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
      products.Remove(product);
    }

    public List<Product> GetProducts()
    {
      return products;
    }
  }
}
