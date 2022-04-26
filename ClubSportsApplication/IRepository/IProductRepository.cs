using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IProductRepository
  {
    IEnumerable<IDataProduct> GetAllProducts();
    IDataProduct GetProduct(int Id);

    IDataProduct AddProduct(IDataProduct product);
    IDataProduct EditProduct(IDataProduct product);
  }
}
