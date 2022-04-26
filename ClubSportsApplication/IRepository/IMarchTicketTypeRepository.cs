using ClubSportsApplication.IDataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IMarchTicketTypeRepository
  {

    IEnumerable<IDataMarchTicketType> GetAllMatchResult();
    IDataMarchTicketType GetMatchResult(int Id);

    IDataMarchTicketType AddMatchResult(IDataMarchTicketType ticketType);
    IDataMarchTicketType EditMatchResult(IDataMarchTicketType ticketType);
  }
}
