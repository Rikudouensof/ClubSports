using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface IMarchTicketTypeService
  {

    IEnumerable<IDataMarchTicketType> AdminGetAll();

    IDataMarchTicketType AdminAddSingle(IDataMarchTicketType data, string userId);

    IDataMarchTicketType AdminEditSingle(IDataMarchTicketType data, string userId);

    IDataMarchTicketType AdminGetSingle(int Id);

    IDataMarchTicketType AdminDeleteSingle(int Id, string userId);





    IEnumerable<IMarchTicketType> UserGetAll(string userId);

    IMarchTicketType UserAddSingle(IMarchTicketType data, string userId);

    IMarchTicketType UserEditeSingle(IMarchTicketType data, string userId);

    IMarchTicketType UserGetSingle(int Id, string userId);

    IMarchTicketType UserDeleteSingle(int Id, string userId);





  }
}
