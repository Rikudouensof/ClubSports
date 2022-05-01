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
  public class VoteOptionRepository : IVoteOptionRepository
  {
    private readonly ApplicationDbContext _db;
    public VoteOptionRepository(ApplicationDbContext db)
    {
      _db = db;
    }

    public IDataVoteOption AddVoteOption(IDataVoteOption voteQuestion)
    {

      _db.VoteOptions.Add((DataVoteOption)voteQuestion);
      _db.SaveChanges();
      return voteQuestion;
    }

    public IDataVoteOption EditVoteOption(IDataVoteOption voteQuestion)
    {
      _db.VoteOptions.Update((DataVoteOption)voteQuestion);
      _db.SaveChanges();
      return voteQuestion;
    }

    public IEnumerable<IDataVoteOption> GetAllVoteOptions()
    {
      var data = _db.VoteOptions.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataVoteOption GetVoteOption(int Id)
    {
      var data = _db.VoteOptions.OrderByDescending(m => m.DateUpdated);
      return data;
    }
  }
}
