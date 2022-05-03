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
  public class MarchService : IMarchService
  {
    public IDataMatch AdminAddSingle(IDataMatch data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMatch AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMatch AdminEditSingle(IDataMatch data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataMatch> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataMatch AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IMatch UserAddSingle(IMatch data, string userId)
    {
      throw new NotImplementedException();
    }

    public IMatch UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IMatch UserEditeSingle(IMatch data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IMatch> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IMatch UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
