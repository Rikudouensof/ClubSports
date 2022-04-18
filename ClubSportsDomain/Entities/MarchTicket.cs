using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class MarchTicket
  {
    public int Id { get; set; }

    public DateTime MarchDate { get; set; }

    public decimal Price { get; set; }

    public string TicketRef { get; set; }
  }

  public class MarchTicketType
  {
    public int Id { get; set; }

    public string Name { get; set; }
  }
}
