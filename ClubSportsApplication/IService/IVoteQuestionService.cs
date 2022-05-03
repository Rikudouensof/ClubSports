using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface IVoteQuestionService
  {

    IEnumerable<IDataVoteQuestion> AdminGetAll();

    IDataVoteQuestion AdminAddSingle(IDataVoteQuestion data, string userId);

    IDataVoteQuestion AdminEditSingle(IDataVoteQuestion data, string userId);

    IDataVoteQuestion AdminGetSingle(int Id);

    IDataVoteQuestion AdminDeleteSingle(int Id, string userId);





    IEnumerable<IVoteQuestion> UserGetAll(string userid);

    IVoteQuestion UserAddSingle(IVoteQuestion data, string userId);

    IVoteQuestion UserEditeSingle(IVoteQuestion data, string userId);

    IVoteQuestion UserGetSingle(int Id, string userId);

    IVoteQuestion UserDeleteSingle(int Id, string userId);





  }
}
