using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IVoteRepository
  {
    IEnumerable<Vote> GetAllVotes();
    Vote GetVote(int Id);

    Vote AddVote(Vote vote);
    Vote EditVote(Vote vote);
  }
}
