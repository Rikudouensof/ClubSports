using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IMarchTicketRepository
  {
    List<MarchTicket> GetAllMarchTickets();
    MarchTicket GetMarchTicket(int Id);

    MarchTicket AddMarchTicket(MarchTicket gallery);
    MarchTicket EditMarchTicket(MarchTicket gallery);
  }

}
