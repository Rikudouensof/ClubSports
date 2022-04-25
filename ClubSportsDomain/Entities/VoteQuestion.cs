using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class VoteQuestion : BaseDataEntity, IVoteQuestion
  {
    public int Id { get; set; }

    public string Name { get; set; }
    public DateTime VoteExpireyDate { get; set; }
  }
}
