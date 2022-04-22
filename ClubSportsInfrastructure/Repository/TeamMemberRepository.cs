using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class TeamMemberRepository : ITeamMemberRepository
  {
    public TeamMember AddTeamMember(TeamMember teamMember)
    {
      throw new NotImplementedException();
    }

    public TeamMember EditTeamMember(TeamMember teamMember)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<TeamMember> GetAllTeamMembers()
    {
      throw new NotImplementedException();
    }

    public TeamMember GetTeamMember(int Id)
    {
      throw new NotImplementedException();
    }
  }
}
