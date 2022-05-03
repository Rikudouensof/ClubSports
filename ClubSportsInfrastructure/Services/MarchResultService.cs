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
  public class MarchResultService : IMarchResultService
  {
    public IDataMatchResult AdminAddSingle(IDataMatchResult data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMatchResult AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMatchResult AdminEditSingle(IDataMatchResult data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataMatchResult> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataMatchResult AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IMatchResult UserAddSingle(IMatchResult data, string userId)
    {
      throw new NotImplementedException();
    }

    public IMatchResult UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IMatchResult UserEditeSingle(IMatchResult data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IMatchResult> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IMatchResult UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
