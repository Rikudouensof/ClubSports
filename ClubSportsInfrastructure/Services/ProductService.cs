using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IService;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.EntityInterface;

namespace ClubSportsInfrastructure.Services
{
  public class ProductService : IProductService
  {
    public IProduct AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataProduct AdminAddSingle(IDataProduct data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataProduct AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataProduct AdminEditSingle(IDataProduct data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataProduct> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataProduct AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IProduct UserAddSingle(IAddProduct data, string userId)
    {
      throw new NotImplementedException();
    }

    public IProduct UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IProduct UserEditeSingle(IAddProduct data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IProduct> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IProduct UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
