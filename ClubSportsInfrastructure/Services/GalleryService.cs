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
  public class GalleryService : IGalleryService
  {
    public IGallery AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataGallery AdminAddSingle(IDataGallery data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataGallery AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataGallery AdminEditSingle(IDataGallery data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataGallery> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataGallery AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IGallery UserAddSingle(IAddGallery data, string userId)
    {
      throw new NotImplementedException();
    }

    public IGallery UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IGallery UserEditeSingle(IAddGallery data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IGallery> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IGallery UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
