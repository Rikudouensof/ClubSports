using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class Team : BaseDataEntity
  {
    public int Id { get; set; }

    public string Name { get; set; }


    public string DateEstablished { get; set; }


    public string ManagerName { get; set; }

    public string CurrentCoachName { get; set; }

    public string PresidentName { get; set; }

    public int NumberOfChanpionship { get; set; }

    public int NumberOfCurrentPlayers { get; set; }

    public int NumberOfTopPlayers { get; set; }

    public string ClubHistory { get; set; }
  }
}
