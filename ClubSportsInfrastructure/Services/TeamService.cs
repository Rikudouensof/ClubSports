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
  public class TeamService : ITeamService
  {
    public ITeam AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeam AdminAddSingle(IDataTeam data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeam AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeam AdminEditSingle(IDataTeam data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataTeam> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataTeam AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ITeam UserAddSingle(IAddTeam data, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeam UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeam UserEditeSingle(IAddTeam data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ITeam> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public ITeam UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
