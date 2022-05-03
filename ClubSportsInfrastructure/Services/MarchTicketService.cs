using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IService;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.EntityInterface;

namespace ClubSportsInfrastructure.Services
{
  public class MarchTicketService : IMarchTicketService
  {
    public IDataMarchTicket AdminAddSingle(IDataMarchTicket data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMarchTicket AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMarchTicket AdminEditSingle(IDataMarchTicket data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataMarchTicket> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataMarchTicket AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IMarchTicket UserAddSingle(IMarchTicket data, string userId)
    {
      throw new NotImplementedException();
    }

    public IMarchTicket UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IMarchTicket UserEditeSingle(IMarchTicket data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IMarchTicket> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IMarchTicket UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
