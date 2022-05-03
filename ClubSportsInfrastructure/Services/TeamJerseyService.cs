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
  public class TeamJerseyService : ITeamJersyService
  {
    public ITeamJersy AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamJersy AdminAddSingle(IDataTeamJersy data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamJersy AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamJersy AdminEditSingle(IDataTeamJersy data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataTeamJersy> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataTeamJersy AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ITeamJersy UserAddSingle(IAddTeamJersy data, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamJersy UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamJersy UserEditeSingle(IAddTeamJersy data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ITeamJersy> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public ITeamJersy UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
