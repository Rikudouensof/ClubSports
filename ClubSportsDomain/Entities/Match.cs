using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class Match : BaseDataEntity, IMatch
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string Venue { get; set; }

    public int HometeamId { get; set; }

    public string AwayTeamId { get; set; }

    public DateTime Date { get; set; }
  }
}
