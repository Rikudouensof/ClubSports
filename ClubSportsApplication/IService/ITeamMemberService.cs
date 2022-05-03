using ClubSportsApplication.IDataModels;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface ITeamMemberService
  {

    IEnumerable<IDataTeamMember> AdminGetAll();

    IDataTeamMember AdminAddSingle(IDataTeamMember data, string userId);

    IDataTeamMember AdminEditSingle(IDataTeamMember data, string userId);

    IDataTeamMember AdminGetSingle(int Id);

    IDataTeamMember AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITeamMember> UserGetAll(string userid);

    ITeamMember UserAddSingle(IAddTeamMember data, string userId);

    ITeamMember UserEditeSingle(IAddTeamMember data, string userId);

    ITeamMember UserGetSingle(int Id, string userId);

    ITeamMember UserDeleteSingle(int Id, string userId);


    ITeamMember AddImage(IDisplayAddImage image, string userId);


  }
}
