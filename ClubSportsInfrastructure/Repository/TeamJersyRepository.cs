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
  public class TeamJersyRepository : ITeamJersyRepository
  {

    private readonly ApplicationDbContext _db;
    public TeamJersyRepository(ApplicationDbContext db)
    {
      _db = db;
    }
    public IDataTeamJersy AddTeamJersy(IDataTeamJersy teamJersy)
    {
      _db.TeamJersies.Add((DataTeamJersy)teamJersy);
      _db.SaveChanges();
      return teamJersy;
    }

    public IDataTeamJersy EditTeamJersy(IDataTeamJersy teamJersy)
    {
      _db.TeamJersies.Update((DataTeamJersy)teamJersy);
      _db.SaveChanges();
      return teamJersy;
    }

    public IEnumerable<IDataTeamJersy> GetAllTeamJersys()
    {
      var data = _db.TeamJersies.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataTeamJersy GetTeamJersy(int Id)
    {
      var data = _db.TeamJersies.OrderByDescending(m => m.DateUpdated).Where(m => m.Id == Id).FirstOrDefault(); ;
      return data;
    }
  }
}
