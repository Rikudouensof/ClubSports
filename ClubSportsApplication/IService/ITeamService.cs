using ClubSportsApplication.IDataModels;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface ITeamService
  {

    IEnumerable<IDataTeam> AdminGetAll();

    IDataTeam AdminAddSingle(IDataTeam data, string userId);

    IDataTeam AdminEditSingle(IDataTeam data, string userId);

    IDataTeam AdminGetSingle(int Id);

    IDataTeam AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITeam> UserGetAll(string userid);

    ITeam UserAddSingle(IAddTeam data, string userId);

    ITeam UserEditeSingle(IAddTeam data, string userId);

    ITeam UserGetSingle(int Id, string userId);

    ITeam UserDeleteSingle(int Id, string userId);

    ITeam AddImage(IDisplayAddImage image, string userId);




  }
}
