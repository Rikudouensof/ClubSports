using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ITeamJersyRepository
  {
    IEnumerable<TeamJersy> GetAllTeamJersys();
    TeamJersy GetTeamJersy(int Id);

    TeamJersy AddTeamJersy(TeamJersy teamJersy);
    TeamJersy EditTeamJersy(TeamJersy teamJersy);
  }
}
