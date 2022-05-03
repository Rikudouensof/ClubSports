using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface IVoteService
  {

    IEnumerable<IDataVote> AdminGetAll();

    IDataVote AdminAddSingle(IDataVote data, string userId);

    IDataVote AdminEditSingle(IDataVote data, string userId);

    IDataVote AdminGetSingle(int Id);

    IDataVote AdminDeleteSingle(int Id, string userId);





    IEnumerable<IVote> UserGetAll(string userid);

    IVote UserAddSingle(IVote data, string userId);

    IVote UserEditeSingle(IVote data, string userId);

    IVote UserGetSingle(int Id, string userId);

    IVote UserDeleteSingle(int Id, string userId);





  }
}
