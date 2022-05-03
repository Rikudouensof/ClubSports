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
  public class TeamRoleService : ITeamRoleService
  {
    public IDataTeamRole AdminAddSingle(IDataTeamRole data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamRole AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamRole AdminEditSingle(IDataTeamRole data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataTeamRole> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataTeamRole AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ITeamRole UserAddSingle(ITeamRole data, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamRole UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamRole UserEditeSingle(ITeamRole data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ITeamRole> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public ITeamRole UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
