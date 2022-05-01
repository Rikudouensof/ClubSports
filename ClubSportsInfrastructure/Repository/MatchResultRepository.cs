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
  public class MatchResultRepository : IMatchResultRepository
  {

    private readonly ApplicationDbContext _db;
    public MatchResultRepository(ApplicationDbContext db)
    {
      _db = db;
    }

    public IDataMatchResult AddMatchResult(IDataMatchResult matchResult)
    {
      _db.MatchResults.Add((DataMatchResult)matchResult);
      _db.SaveChanges();
      return matchResult;
    }

    public IDataMatchResult EditMatchResult(IDataMatchResult matchResult)
    {
      _db.MatchResults.Update((DataMatchResult)matchResult);
      _db.SaveChanges();
      return matchResult;
    }

    public IEnumerable<IDataMatchResult> GetAllMatchResult()
    {
      var data = _db.MatchResults.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataMatchResult GetMatchResult(int Id)
    {
      var data = _db.MatchResults.Where(m => m.Id == Id).FirstOrDefault();
      return data;
    }
  }
}
