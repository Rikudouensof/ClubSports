using ClubSportsApplication.IDataModels;
using ClubSportsDomain.BaseEntityInterface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.DataModel
{
  public class DataMatchTicket : IDataMarchTicket
  {
    public DataMatch Match { get; set; }

    public DataMatchTicketType MatchTicketType { get; set; }
    public DataUser UpdatedBy { get; set; }
    public int Id { get; set; }
    public DateTime MarchDate { get; set; }
    public int MatchId { get; set; }
    public int MatchTicketTypeId { get; set; }
    public decimal Price { get; set; }
    public string TicketRef { get; set; }
    public DateTime DateUpdated { get; set; }
    public bool isDeleted { get; set; }
    public string UpdatedById { get; set; }
  }
}
