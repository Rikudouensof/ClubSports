using ClubSportsApplication.IDataModels;
using ClubSportsDomain.BaseEntityInterface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.DataModel
{
  public class DataMatch : IDataMatch
  {
    public DataTeam Hometeam { get; set; }
    public DataTeam AwayTeam { get; set; }
    public DataUser UpdatedBy { get; set; }
    public string AwayTeamId { get; set; }
    public DateTime Date { get; set; }
    public int HometeamId { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Venue { get; set; }
    public DateTime DateUpdated { get; set; }
    public bool isDeleted { get; set; }
    public string UpdatedById { get; set; }
  }
}
