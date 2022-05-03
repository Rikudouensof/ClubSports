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
  public class VideoService : IVideoService
  {
    public IVideo AddVideo(IDisplayAddImage video, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVideo AdminAddSingle(IDataVideo data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVideo AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVideo AdminEditSingle(IDataVideo data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataVideo> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataVideo AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IVideo UserAddSingle(IAddVideo data, string userId)
    {
      throw new NotImplementedException();
    }

    public IVideo UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IVideo UserEditeSingle(IAddVideo data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IVideo> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public IVideo UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
