using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ITeamJersyRepository
  {
    IEnumerable<IDataTeamJersy> GetAllTeamJersys();
    IDataTeamJersy GetTeamJersy(int Id);

    IDataTeamJersy AddTeamJersy(IDataTeamJersy teamJersy);
    IDataTeamJersy EditTeamJersy(IDataTeamJersy teamJersy);
  }
}
