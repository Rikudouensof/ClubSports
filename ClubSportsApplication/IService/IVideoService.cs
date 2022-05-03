using ClubSportsApplication.IDataModels;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface IVideoService
  {

    IEnumerable<IDataVideo> AdminGetAll();

    IDataVideo AdminAddSingle(IDataVideo data, string userId);

    IDataVideo AdminEditSingle(IDataVideo data, string userId);

    IDataVideo AdminGetSingle(int Id);

    IDataVideo AdminDeleteSingle(int Id, string userId);





    IEnumerable<IVideo> UserGetAll(string userid);

    IVideo UserAddSingle(IAddVideo data, string userId);

    IVideo UserEditeSingle(IAddVideo data, string userId);

    IVideo UserGetSingle(int Id, string userId);

    IVideo UserDeleteSingle(int Id, string userId);

    IVideo AddVideo(IDisplayAddImage video, string userId);






  }
}
