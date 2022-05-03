using ClubSportsApplication.IDataModels;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface ITeamSponsorService
  {

    IEnumerable<IDataTeamSponsor> AdminGetAll();

    IDataTeamSponsor AdminAddSingle(IDataTeamSponsor data, string userId);

    IDataTeamSponsor AdminEditSingle(IDataTeamSponsor data, string userId);

    IDataTeamSponsor AdminGetSingle(int Id);

    IDataTeamSponsor AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITeamSponsor> UserGetAll(string userid);

    ITeamSponsor UserAddSingle(IAddTeamSponsor data, string userId);

    ITeamSponsor UserEditeSingle(IAddTeamSponsor data, string userId);

    ITeamSponsor UserGetSingle(int Id, string userId);

    ITeamSponsor UserDeleteSingle(int Id, string userId);

    ITeamSponsor AddImage(IDisplayAddImage image, string userId);



  }
}
