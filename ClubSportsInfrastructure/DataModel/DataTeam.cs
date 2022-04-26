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
  public class DataTeam : IDataTeam
  {
    public DataUser UpdatedBy { get; set; }
    public string ClubHistory { get; set; }
    public string CurrentCoachName { get; set; }
    public string DateEstablished { get; set; }
    public int Id { get; set; }
    public string ManagerName { get; set; }
    public string Name { get; set; }
    public int NumberOfChanpionship { get; set; }
    public int NumberOfCurrentPlayers { get; set; }
    public int NumberOfTopPlayers { get; set; }
    public string PresidentName { get; set; }
    public DateTime DateUpdated { get; set; }
    public bool isDeleted { get; set; }
    public string UpdatedById { get; set; }
  }
}
