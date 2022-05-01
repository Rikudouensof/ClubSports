using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using ClubSportsInfrastructure.Data;
using ClubSportsInfrastructure.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class TeamMemberRepository : ITeamMemberRepository
  {

    private readonly ApplicationDbContext _db;
    public TeamMemberRepository(ApplicationDbContext db)
    {
      _db = db;
    }

    public IDataTeamMember AddTeamMember(IDataTeamMember teamMember)
    {
      _db.TeamMembers.Add((DataTeamMember)teamMember);
      _db.SaveChanges();
      return teamMember;
    }

      public IDataTeamMember EditTeamMember(IDataTeamMember teamMember)
    {
      _db.TeamMembers.Update((DataTeamMember)teamMember);
      _db.SaveChanges();
      return teamMember;
    }

    public IEnumerable<IDataTeamMember> GetAllTeamMembers()
    {
      var data = _db.TeamMembers.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataTeamMember GetTeamMember(int Id)
    {
      var data = _db.TeamMembers.OrderByDescending(m => m.DateUpdated);
      return data;
    }
  }
}
