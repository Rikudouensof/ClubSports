using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IRepository;
using ClubSportsInfrastructure.Data;
using ClubSportsInfrastructure.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class TeamRoleRepository : ITeamRoleRepository
  {
    private readonly ApplicationDbContext _db;
    public TeamRoleRepository(ApplicationDbContext db)
    {
      _db = db;
    }
    public IDataTeamRole AddVote(IDataTeamRole teamRole)
    {
      _db.TeamRoles.Add((DataTeamRole)teamRole);
      _db.SaveChanges();
      return teamRole;
    }

    public IDataTeamRole EditVote(IDataTeamRole teamRole)
    {
      _db.TeamRoles.Add((DataTeamRole)teamRole);
      _db.SaveChanges();
      return teamRole;
    }

    public IEnumerable<IDataTeamRole> GetAllTeamRoles()
    {
      var data = _db.TeamRoles.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataTeamRole GetVote(int Id)
    {
      var data = _db.TeamRoles.OrderByDescending(m => m.DateUpdated);
      return data;
    }
  }
}
