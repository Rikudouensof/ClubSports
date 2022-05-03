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
  public class MarchFormationService : IMarchFormationService
  {
    public IDataMatchFormation AdminAddSingle(IDataMatchFormation data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMatchFormation AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMatchFormation AdminEditSingle(IDataMatchFormation data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataMatchFormation> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataMatchFormation AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IMatchFormation UserAddSingle(IMatchFormation data, string userId)
    {
      throw new NotImplementedException();
    }

    public IMatchFormation UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IMatchFormation UserEditeSingle(IMatchFormation data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IMatchFormation> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IMatchFormation UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
