using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ITeamSponsorRepository
  {
    IEnumerable<IDataTeamSponsor> GetAllTeamSponsors();
    IDataTeamSponsor GetTeamSponsor(int Id);

    IDataTeamSponsor AddTeamSponsor(IDataTeamSponsor teamSponsor);
    IDataTeamSponsor EditTeamSponsor(IDataTeamSponsor teamSponsor);
  }
}
