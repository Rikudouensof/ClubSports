using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class VoteOptionRepository : IVoteOptionRepository
  {
    public VoteOption AddVoteOption(VoteOption voteQuestion)
    {
      throw new NotImplementedException();
    }

    public VoteOption EditVoteOption(VoteOption voteQuestion)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<VoteOption> GetAllVoteOptions()
    {
      throw new NotImplementedException();
    }

    public VoteOption GetVoteOption(int Id)
    {
      throw new NotImplementedException();
    }
  }
}
