using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface IMarchResultService
  {

    IEnumerable<IDataMatchResult> AdminGetAll();

    IDataMatchResult AdminAddSingle(IDataMatchResult data, string userId);

    IDataMatchResult AdminEditSingle(IDataMatchResult data, string userId);

    IDataMatchResult AdminGetSingle(int Id);

    IDataMatchResult AdminDeleteSingle(int Id, string userId);





    IEnumerable<IMatchResult> UserGetAll(string userId);

    IMatchResult UserAddSingle(IMatchResult data, string userId);

    IMatchResult UserEditeSingle(IMatchResult data, string userId);

    IMatchResult UserGetSingle(int Id, string userId);

    IMatchResult UserDeleteSingle(int Id, string userId);





  }
}
