using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ITeamMemberRepository
  {
    IEnumerable<IDataTeamMember> GetAllTeamMembers();
    IDataTeamMember GetTeamMember(int Id);

    IDataTeamMember AddTeamMember(IDataTeamMember teamMember);
    IDataTeamMember EditTeamMember(IDataTeamMember teamMember);
  }
}
