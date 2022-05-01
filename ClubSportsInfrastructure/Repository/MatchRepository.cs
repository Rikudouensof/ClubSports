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
  public class MatchRepository : IMatchRepository
  {


    private readonly ApplicationDbContext _db;
    public MatchRepository(ApplicationDbContext db)
    {
      _db = db;
    }

    public IDataMatch AddMarch(IDataMatch match)
    {
      _db.Matches.Add((DataMatch)match);
      _db.SaveChanges();
      return match;
    }

    public IDataMatch EditMarch(IDataMatch match)
    {
      _db.Matches.Update((DataMatch)match);
      _db.SaveChanges();
      return match;
    }

    public IEnumerable<IDataMatch> GetAllMarches()
    {
      var data = _db.Matches.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataMatch GetMarch(int Id)
    {
      var data = _db.Matches.Where(m => m.Id == Id).FirstOrDefault();
      return data;
    }
  }
}
