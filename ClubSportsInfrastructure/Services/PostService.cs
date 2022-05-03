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
  public class PostService : IPostService
  {
    public IPost AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPost AdminAddSingle(IDataPost data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPost AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPost AdminEditSingle(IDataPost data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataPost> AdminGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPost AdminGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IPost UserAddSingle(IAddPost data, string userId)
    {
      throw new NotImplementedException();
    }

    public IPost UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IPost UserEditeSingle(IAddPost data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IPost> UserGetAll()
    {
      throw new NotImplementedException();
    }

    public IPost UserGetSingle(int Id)
    {
      throw new NotImplementedException();
    }
  }
}
