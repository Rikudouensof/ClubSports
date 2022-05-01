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
  public class VoteRepository : IVoteRepository
  {

    private readonly ApplicationDbContext _db;
    public VoteRepository(ApplicationDbContext db)
    {
      _db = db;
    }


    public IDataVote AddVote(IDataVote vote)
    {
      _db.Votes.Add((DataVote)vote);
      _db.SaveChanges();
      return vote;
    }

    public IDataVote EditVote(IDataVote vote)
    {
      _db.Votes.Update((DataVote)vote);
      _db.SaveChanges();
      return vote;
    }

    public IEnumerable<IDataVote> GetAllVotes()
    {
      var data = _db.Votes.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataVote GetVote(int Id)
    {
      var data = _db.Votes.OrderByDescending(m => m.DateUpdated).Where(m => m.Id == Id).FirstOrDefault(); ;
      return data;
    }
  }
}
