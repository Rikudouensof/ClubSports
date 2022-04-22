using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ITeamRepository
  {
    IEnumerable<Team> GetAllTeams();
    Team GetTeam(int Id);

    Team AddTeam(Team team);
    Team EditTeam(Team team);
  }
}
