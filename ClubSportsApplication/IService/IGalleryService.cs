using ClubSportsApplication.IDataModels;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface IGalleryService
  {

    IEnumerable<IDataGallery> AdminGetAll();

    IDataGallery AdminAddSingle(IDataGallery data, string userId);

    IDataGallery AdminEditSingle(IDataGallery data, string userId);

    IDataGallery AdminGetSingle(int Id);

    IDataGallery AdminDeleteSingle(int Id, string userId);





    IEnumerable<IGallery> UserGetAll(string userId);

    IGallery UserAddSingle(IAddGallery data, string userId);

    IGallery UserEditeSingle(IAddGallery data, string userId);

    IGallery UserGetSingle(int Id, string userId);

    IGallery UserDeleteSingle(int Id, string userId);

    IGallery AddImage(IDisplayAddImage image, string userId);


  }
}
