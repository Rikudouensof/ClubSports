using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class TeamSponsorRepository : ITeamSponsorRepository
  {
    public TeamSponsor AddTeamSponsor(TeamSponsor teamSponsor)
    {
      throw new NotImplementedException();
    }

    public TeamSponsor EditTeamSponsor(TeamSponsor teamSponsor)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<TeamSponsor> GetAllTeamSponsors()
    {
      throw new NotImplementedException();
    }

    public TeamSponsor GetTeamSponsor(int Id)
    {
      throw new NotImplementedException();
    }
  }
}
