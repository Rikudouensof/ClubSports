using ClubSportsApplication.IDataModels;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface ITeamJersyService
  {

    IEnumerable<IDataTeamJersy> AdminGetAll();

    IDataTeamJersy AdminAddSingle(IDataTeamJersy data, string userId);

    IDataTeamJersy AdminEditSingle(IDataTeamJersy data, string userId);

    IDataTeamJersy AdminGetSingle(int Id);

    IDataTeamJersy AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITeamJersy> UserGetAll(string userid);

    ITeamJersy UserAddSingle(IAddTeamJersy data, string userId);

    ITeamJersy UserEditeSingle(IAddTeamJersy data, string userId);

    ITeamJersy UserGetSingle(int Id, string userId);

    ITeamJersy UserDeleteSingle(int Id, string userId);

    ITeamJersy AddImage(IDisplayAddImage image, string userId);

  }
}
