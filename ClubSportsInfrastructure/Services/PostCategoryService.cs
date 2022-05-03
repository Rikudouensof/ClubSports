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
  public class PostCategoryService : IPostCategoryService
  {
    public IDataPostCategory AdminAddSingle(IDataPostCategory data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPostCategory AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPostCategory AdminEditSingle(IDataPostCategory data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataPostCategory> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataPostCategory AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IPostCategory UserAddSingle(IPostCategory data, string userId)
    {
      throw new NotImplementedException();
    }

    public IPostCategory UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IPostCategory UserEditeSingle(IPostCategory data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IPostCategory> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IPostCategory UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
