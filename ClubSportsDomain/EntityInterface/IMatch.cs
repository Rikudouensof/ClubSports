using System;

namespace ClubSportsDomain.EntityInterface
{
  public interface IMatch
  {
    string AwayTeamId { get; set; }
    DateTime Date { get; set; }
    int HometeamId { get; set; }
    int Id { get; set; }
    string Name { get; set; }
    string Venue { get; set; }
  }
}