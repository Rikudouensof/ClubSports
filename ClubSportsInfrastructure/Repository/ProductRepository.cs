using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using ClubSportsInfrastructure.Data;
using ClubSportsInfrastructure.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class ProductRepository : IProductRepository
  {

    private readonly ApplicationDbContext _db;
    public ProductRepository(ApplicationDbContext db)
    {
      _db = db;
    }


    public IDataProduct AddProduct(IDataProduct product)
    {
      _db.SellableProducts.Add((DataProduct)product);
      _db.SaveChanges();
      return product; 
    }

    public IDataProduct EditProduct(IDataProduct product)
    {
      _db.SellableProducts.Update((DataProduct)product);
      _db.SaveChanges();
      return product;
    }

    public IEnumerable<IDataProduct> GetAllProducts()
    {
      var data = _db.SellableProducts.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataProduct GetProduct(int Id)
    {
      var data = _db.SellableProducts.OrderByDescending(m => m.DateUpdated).Where(m => m.Id == Id).FirstOrDefault(); ;
      return data;
    }
  }
}
