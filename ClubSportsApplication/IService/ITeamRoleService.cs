using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface ITeamRoleService
  {

    IEnumerable<IDataTeamRole> AdminGetAll();

    IDataTeamRole AdminAddSingle(IDataTeamRole data, string userId);

    IDataTeamRole AdminEditSingle(IDataTeamRole data, string userId);

    IDataTeamRole AdminGetSingle(int Id);

    IDataTeamRole AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITeamRole> UserGetAll(string userid);

    ITeamRole UserAddSingle(ITeamRole data, string userId);

    ITeamRole UserEditeSingle(ITeamRole data, string userId);

    ITeamRole UserGetSingle(int Id, string userId);

    ITeamRole UserDeleteSingle(int Id, string userId);





  }
}
