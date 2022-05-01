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
  public class TeamRepository : ITeamRepository
  {
    private readonly ApplicationDbContext _db;
    public TeamRepository(ApplicationDbContext db)
    {
      _db = db;
    }
    public IDataTeam AddTeam(IDataTeam team)
    {
      _db.Teams.Add((DataTeam)team);
      _db.SaveChanges();
      return team;
    }

    public IDataTeam EditTeam(IDataTeam team)
    {
      _db.Teams.Update((DataTeam)team);
      _db.SaveChanges();
      return team;
    }

    public IEnumerable<IDataTeam> GetAllTeams()
    {

      var data = _db.Teams.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataTeam GetTeam(int Id)
    {
      var data = _db.Teams.OrderByDescending(m => m.DateUpdated);
      return data;
    }
  }
}
