using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class ProductRepository : IProductRepository
  {
    public Product AddProduct(Product product)
    {
      throw new NotImplementedException();
    }

    public Product EditProduct(Product product)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAllProducts()
    {
      throw new NotImplementedException();
    }

    public Product GetProduct(int Id)
    {
      throw new NotImplementedException();
    }
  }
}
