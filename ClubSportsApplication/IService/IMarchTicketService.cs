using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface IMarchTicketService
  {

    IEnumerable<IDataMarchTicket> AdminGetAll();

    IDataMarchTicket AdminAddSingle(IDataMarchTicket data, string userId);

    IDataMarchTicket AdminEditSingle(IDataMarchTicket data, string userId);

    IDataMarchTicket AdminGetSingle(int Id);

    IDataMarchTicket AdminDeleteSingle(int Id, string userId);





    IEnumerable<IMarchTicket> UserGetAll(string userId);

    IMarchTicket UserAddSingle(IMarchTicket data, string userId);

    IMarchTicket UserEditeSingle(IMarchTicket data, string userId);

    IMarchTicket UserGetSingle(int Id, string userId);

    IMarchTicket UserDeleteSingle(int Id, string userId);





  }
}
