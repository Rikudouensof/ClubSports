using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class MarchTicket : BaseDataEntity, IMarchTicket
  {
    public int Id { get; set; }

    public DateTime MarchDate { get; set; }

    public decimal Price { get; set; }

    public string TicketRef { get; set; }

    public int MatchId { get; set; }

    public int MatchTicketTypeId { get; set; }
  }

  public class MarchTicketType : BaseDataEntity, IMarchTicketType
  {
    public int Id { get; set; }

    public string Name { get; set; }
  }
}
