using System;

namespace ClubSportsDomain.EntityInterface
{
  public interface IMarchTicket
  {
    int Id { get; set; }
    DateTime MarchDate { get; set; }
    int MatchId { get; set; }
    int MatchTicketTypeId { get; set; }
    decimal Price { get; set; }
    string TicketRef { get; set; }
  }
}