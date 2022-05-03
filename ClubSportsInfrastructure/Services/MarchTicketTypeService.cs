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
  public class MarchTicketTypeService : IMarchTicketTypeService
  {
    public IDataMarchTicketType AdminAddSingle(IDataMarchTicketType data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMarchTicketType AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMarchTicketType AdminEditSingle(IDataMarchTicketType data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataMarchTicketType> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataMarchTicketType AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IMarchTicketType UserAddSingle(IMarchTicketType data, string userId)
    {
      throw new NotImplementedException();
    }

    public IMarchTicketType UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IMarchTicketType UserEditeSingle(IMarchTicketType data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IMarchTicketType> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IMarchTicketType UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

}
