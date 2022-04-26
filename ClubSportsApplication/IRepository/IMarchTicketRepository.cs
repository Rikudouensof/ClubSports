using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IMarchTicketRepository
  {
    IEnumerable<IDataMarchTicket> GetAllMarchTickets();
    IDataMarchTicket GetMarchTicket(int Id);

    IDataMarchTicket AddMarchTicket(IDataMarchTicket gallery);
    IDataMarchTicket EditMarchTicket(IDataMarchTicket gallery);
  }

}
