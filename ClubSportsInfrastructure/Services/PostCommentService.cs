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
  public class PostCommentService : IPostCommentService
  {
    public IDataPostComment AdminAddSingle(IDataPostComment data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPostComment AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPostComment AdminEditSingle(IDataPostComment data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataPostComment> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataPostComment AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IPostComment UserAddSingle(IAddPostComment data, string userId)
    {
      throw new NotImplementedException();
    }

    public IPostComment UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IPostComment UserEditeSingle(IAddPostComment data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IPostComment> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IPostComment UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
