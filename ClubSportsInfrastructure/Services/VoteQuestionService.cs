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
  public class VoteQuestionService : IVoteOptionsService
  {
    public IDataVoteOption AdminAddSingle(IDataVoteOption data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVoteOption AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVoteOption AdminEditSingle(IDataVoteOption data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataVoteOption> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataVoteOption AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IVoteOption UserAddSingle(IVoteOption data, string userId)
    {
      throw new NotImplementedException();
    }

    public IVideo UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IVoteOption UserEditeSingle(IVoteOption data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IVoteOption> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public IVoteOption UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
