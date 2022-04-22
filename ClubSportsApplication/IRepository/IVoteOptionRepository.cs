using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IVoteOptionRepository
  {
    IEnumerable<VoteOption> GetAllVoteOptions();
    VoteOption GetVoteOption(int Id);

    VoteOption AddVoteOption(VoteOption voteQuestion);
    VoteOption EditVoteOption(VoteOption voteQuestion);
  }
}
