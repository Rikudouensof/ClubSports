using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ITeamRepository
  {
    IEnumerable<IDataTeam> GetAllTeams();
    IDataTeam GetTeam(int Id);

    IDataTeam AddTeam(IDataTeam team);
    IDataTeam EditTeam(IDataTeam team);
  }
}
