using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ITeamMemberRepository
  {
    IEnumerable<TeamMember> GetAllTeamMembers();
    TeamMember GetTeamMember(int Id);

    TeamMember AddTeamMember(TeamMember teamMember);
    TeamMember EditTeamMember(TeamMember teamMember);
  }
}
