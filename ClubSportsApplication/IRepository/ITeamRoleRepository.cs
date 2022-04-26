using ClubSportsApplication.IDataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ITeamRoleRepository
  {

    IEnumerable<IDataTeamRole> GetAllTeamRoles();
    IDataTeamRole GetVote(int Id);

    IDataTeamRole AddVote(IDataTeamRole teamRole);
    IDataTeamRole EditVote(IDataTeamRole teamRole);
  }
}
