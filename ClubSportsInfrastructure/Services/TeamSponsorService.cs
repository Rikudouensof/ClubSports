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
  public class TeamSponsorService : ITeamSponsorService
  {
    public ITeamSponsor AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamSponsor AdminAddSingle(IDataTeamSponsor data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamSponsor AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamSponsor AdminEditSingle(IDataTeamSponsor data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataTeamSponsor> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataTeamSponsor AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ITeamSponsor UserAddSingle(IAddTeamSponsor data, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamSponsor UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamSponsor UserEditeSingle(IAddTeamSponsor data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ITeamSponsor> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public ITeamSponsor UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
