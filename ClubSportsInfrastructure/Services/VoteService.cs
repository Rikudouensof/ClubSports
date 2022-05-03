using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IService;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.EntityInterface;

namespace ClubSportsInfrastructure.Services
{
  public class VoteService : IVoteServices
  {
    public IDataVote AdminAddSingle(IDataVote data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVote AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVote AdminEditSingle(IDataVote data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataVote> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataVote AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IVote UserAddSingle(IVote data, string userId)
    {
      throw new NotImplementedException();
    }

    public IVote UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IVote UserEditeSingle(IVote data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IVote> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public IVote UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
