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

 
  public class VoteQuestionRepository : IVoteQuestionRepository
  {

    private readonly ApplicationDbContext _db;
    public VoteQuestionRepository(ApplicationDbContext db)
    {
      _db = db;
    }
    public IDataVoteQuestion AddVoteQuestion(IDataVoteQuestion voteQuestion)
    {
      _db.VoteQuestions.Add((DataVoteQuestion)voteQuestion);
      _db.SaveChanges();
      return voteQuestion;
    }

    public IDataVoteQuestion EditVoteQuestion(IDataVoteQuestion voteQuestion)
    {
      _db.VoteQuestions.Update((DataVoteQuestion)voteQuestion);
      _db.SaveChanges();
      return voteQuestion;
    }

    public IEnumerable<IDataVoteQuestion> GetAllVoteQuestions()
    {
      var data = _db.VoteQuestions.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataVoteQuestion GetVoteQuestion(int Id)
    {
      var data = _db.VoteQuestions.OrderByDescending(m => m.DateUpdated).Where(m => m.Id == Id).FirstOrDefault(); ;
      return data;
    }
  }
}
