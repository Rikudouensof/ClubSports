using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ITeamSponsorRepository
  {
    IEnumerable<TeamSponsor> GetAllTeamSponsors();
    TeamSponsor GetTeamSponsor(int Id);

    TeamSponsor AddTeamSponsor(TeamSponsor teamSponsor);
    TeamSponsor EditTeamSponsor(TeamSponsor teamSponsor);
  }
}
