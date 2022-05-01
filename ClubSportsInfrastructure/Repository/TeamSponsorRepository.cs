using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using ClubSportsInfrastructure.Data;
using ClubSportsInfrastructure.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class TeamSponsorRepository : ITeamSponsorRepository
  {
    private readonly ApplicationDbContext _db;
    public TeamSponsorRepository(ApplicationDbContext db)
    {
      _db = db;
    }
    public IDataTeamSponsor AddTeamSponsor(IDataTeamSponsor teamSponsor)
    {
      _db.TeamSponsors.Add((DataTeamSponsor)teamSponsor);
      _db.SaveChanges();
      return teamSponsor;
    }

    public IDataTeamSponsor EditTeamSponsor(IDataTeamSponsor teamSponsor)
    {
      _db.TeamSponsors.Update((DataTeamSponsor)teamSponsor);
      _db.SaveChanges();
      return teamSponsor;
    }

    public IEnumerable<IDataTeamSponsor> GetAllTeamSponsors()
    {
      var data = _db.TeamSponsors.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataTeamSponsor GetTeamSponsor(int Id)
    {
      var data = _db.TeamSponsors.OrderByDescending(m => m.DateUpdated).Where(m => m.Id == Id).FirstOrDefault(); ;
      return data;
    }
  }
}

