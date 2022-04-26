using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IVoteQuestionRepository
  {
    IEnumerable<IDataVoteQuestion> GetAllVoteQuestions();
    IDataVoteQuestion GetVoteQuestion(int Id);

    IDataVoteQuestion AddVoteQuestion(IDataVoteQuestion voteQuestion);
    IDataVoteQuestion EditVoteQuestion(IDataVoteQuestion voteQuestion);
  }
}
