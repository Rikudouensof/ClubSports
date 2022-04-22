using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class TeamRepository : ITeamRepository
  {
    public Team AddTeam(Team team)
    {
      throw new NotImplementedException();
    }

    public Team EditTeam(Team team)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Team> GetAllTeams()
    {
      throw new NotImplementedException();
    }

    public Team GetTeam(int Id)
    {
      throw new NotImplementedException();
    }
  }
}
