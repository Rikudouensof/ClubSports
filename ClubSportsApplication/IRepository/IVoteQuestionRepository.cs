using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IVoteQuestionRepository
  {
    IEnumerable<VoteQuestion> GetAllVoteQuestions();
    VoteQuestion GetVoteQuestion(int Id);

    VoteQuestion AddVoteQuestion(VoteQuestion voteQuestion);
    VoteQuestion EditVoteQuestion(VoteQuestion voteQuestion);
  }
}
