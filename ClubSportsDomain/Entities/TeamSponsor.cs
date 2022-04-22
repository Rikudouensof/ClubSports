using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class TeamSponsor : BaseDataEntity, ITeamSponsor
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string ImageLink { get; set; }

  }
}
