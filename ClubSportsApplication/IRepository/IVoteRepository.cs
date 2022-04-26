using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IVoteRepository
  {
    IEnumerable<IDataVote> GetAllVotes();
    IDataVote GetVote(int Id);

    IDataVote AddVote(IDataVote vote);
    IDataVote EditVote(IDataVote vote);
  }
}
