using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class VoteRepository : IVoteRepository
  {
    public Vote AddVote(Vote vote)
    {
      throw new NotImplementedException();
    }

    public Vote EditVote(Vote vote)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Vote> GetAllVotes()
    {
      throw new NotImplementedException();
    }

    public Vote GetVote(int Id)
    {
      throw new NotImplementedException();
    }
  }
}
