using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IRepository;
using ClubSportsInfrastructure.Data;
using ClubSportsInfrastructure.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class MarchFormationReposiory : IMarchFormationReposiory
  {

    private readonly ApplicationDbContext _db;
    public MarchFormationReposiory(ApplicationDbContext db)
    {
      _db = db;
    }

    public IDataMatchFormation AddMarchFormation(IDataMatchFormation formation)
    {
      _db.MatchFormations.Add((DataMatchFormation)formation);
      _db.SaveChanges();
      return formation;
    }

    public IDataMatchFormation EditMarchFormation(IDataMatchFormation formation)
    {
      _db.MatchFormations.Update((DataMatchFormation)formation);
      _db.SaveChanges();
      return formation;
    }

    public IEnumerable<IDataMatchFormation> GetAllMarchFormations()
    {
      var data = _db.MatchFormations.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataMatchFormation GetMarchFormation(int Id)
    {
      var data = _db.MatchFormations.OrderByDescending(m => m.DateUpdated).Where(m => m.Id == Id).FirstOrDefault();
      return data;
    }
  }
}
