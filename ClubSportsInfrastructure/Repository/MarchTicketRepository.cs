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
  public class MarchTicketRepository : IMarchTicketRepository
  {

    private readonly ApplicationDbContext _db;
    public MarchTicketRepository(ApplicationDbContext db)
    {
      _db = db;
    }


    public IDataMarchTicket AddMarchTicket(IDataMarchTicket marchTicket)
    {
      _db.MatchTickets.Add((DataMatchTicket)marchTicket);
      _db.SaveChanges();
      return marchTicket;
    }

    public IDataMarchTicket EditMarchTicket(IDataMarchTicket marchTicket)
    {
      _db.MatchTickets.Add((DataMatchTicket)marchTicket);
      _db.SaveChanges();
      return marchTicket;
    }

    public IEnumerable<IDataMarchTicket> GetAllMarchTickets()
    {
      var data = _db.MatchTickets.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataMarchTicket GetMarchTicket(int Id)
    {
      var data = _db.MatchTickets.Where(m => m.Id == Id).FirstOrDefault();
      return data;
    }
  }
}
