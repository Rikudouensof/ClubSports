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
  public class MarchTicketTypeRepository : IMarchTicketTypeRepository
  {
    private readonly ApplicationDbContext _db;
    public MarchTicketTypeRepository(ApplicationDbContext db)
    {
      _db = db;
    }
    public IDataMarchTicketType AddMatchResult(IDataMarchTicketType ticketType)
    {
      _db.MatchTicketTypes.Add((DataMatchTicketType)ticketType);
      _db.SaveChanges();
      return ticketType;
    }

    public IDataMarchTicketType EditMatchResult(IDataMarchTicketType ticketType)
    {
      _db.MatchTicketTypes.Update((DataMatchTicketType)ticketType);
      _db.SaveChanges();
      return ticketType;
    }

    public IEnumerable<IDataMarchTicketType> GetAllMatchResult()
    {
      var data = _db.MatchTicketTypes.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataMarchTicketType GetMatchResult(int Id)
    {
      var data = _db.MatchTicketTypes.OrderByDescending(m => m.DateUpdated);
      return data;
    }
  }
}
