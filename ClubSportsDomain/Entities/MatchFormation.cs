using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class MatchFormation : BaseDataEntity, IMatchFormation
  {
    public int Id { get; set; }

    public string Name { get; set; }
  }
}
