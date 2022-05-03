using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface IVoteOptionsService
  {

    IEnumerable<IDataVoteOption> AdminGetAll();

    IDataVoteOption AdminAddSingle(IDataVoteOption data, string userId);

    IDataVoteOption AdminEditSingle(IDataVoteOption data, string userId);

    IDataVoteOption AdminGetSingle(int Id);

    IDataVoteOption AdminDeleteSingle(int Id, string userId);





    IEnumerable<IVoteOption> UserGetAll(string userid);

    IVoteOption UserAddSingle(IVoteOption data, string userId);

    IVoteOption UserEditeSingle(IVoteOption data, string userId);

    IVoteOption UserGetSingle(int Id, string userId);

    IVideo UserDeleteSingle(int Id, string userId);





  }
}
