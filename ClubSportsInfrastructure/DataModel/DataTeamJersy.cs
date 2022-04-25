using ClubSportsDomain.BaseEntityInterface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.DataModel
{
  public class DataTeamJersy : ITeamJersy, IBaseDataEntity
  {
    public DataTeam Team { get; set; }
    public DataUser UpdatedBy { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    public string ImageLink { get; set; }
    public string Name { get; set; }
    public int TeamId { get; set; }
    public DateTime DateUpdated { get; set; }
    public bool isDeleted { get; set; }
    public string UpdatedById { get; set; }
  }
}
