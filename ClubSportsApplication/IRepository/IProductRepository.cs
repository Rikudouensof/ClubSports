using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IProductRepository
  {
    IEnumerable<Product> GetAllProducts();
    Product GetProduct(int Id);

    Product AddProduct(Product product);
    Product EditProduct(Product product);
  }
}
