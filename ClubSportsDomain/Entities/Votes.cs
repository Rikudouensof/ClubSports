using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class Votes : BaseDataEntity
  {

    public int Id { get; set; }

    public int VotingId { get; set; }

    public string OptionId { get; set; }
  }
}
