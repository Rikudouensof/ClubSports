using System;

namespace ClubSportsDomain.EntityInterface
{
  public interface IVoteQuestion
  {
    int Id { get; set; }
    string Name { get; set; }

     DateTime VoteExpireyDate { get; set; }
  }
}