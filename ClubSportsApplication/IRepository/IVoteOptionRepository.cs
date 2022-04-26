using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IVoteOptionRepository
  {
    IEnumerable<IDataVoteOption> GetAllVoteOptions();
    IDataVoteOption GetVoteOption(int Id);

    IDataVoteOption AddVoteOption(IDataVoteOption voteQuestion);
    IDataVoteOption EditVoteOption(IDataVoteOption voteQuestion);
  }
}
