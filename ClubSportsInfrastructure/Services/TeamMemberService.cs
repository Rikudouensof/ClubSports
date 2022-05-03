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
  public class TeamMemberService : ITeamMemberService
  {
    public ITeamMember AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamMember AdminAddSingle(IDataTeamMember data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamMember AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamMember AdminEditSingle(IDataTeamMember data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataTeamMember> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataTeamMember AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ITeamMember UserAddSingle(IAddTeamMember data, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamMember UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamMember UserEditeSingle(IAddTeamMember data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ITeamMember> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public ITeamMember UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
