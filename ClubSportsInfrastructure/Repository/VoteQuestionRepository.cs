using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class VoteQuestionRepository : IVoteQuestionRepository
  {
    public VoteQuestion AddVoteQuestion(VoteQuestion voteQuestion)
    {
      throw new NotImplementedException();
    }

    public VoteQuestion EditVoteQuestion(VoteQuestion voteQuestion)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<VoteQuestion> GetAllVoteQuestions()
    {
      throw new NotImplementedException();
    }

    public VoteQuestion GetVoteQuestion(int Id)
    {
      throw new NotImplementedException();
    }
  }
}
