using ClubSportsApplication.IDataModels;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface IPostService
  {

    IEnumerable<IDataPost> AdminGetAll(string userId);

    IDataPost AdminAddSingle(IDataPost data, string userId);

    IDataPost AdminEditSingle(IDataPost data, string userId);

    IDataPost AdminGetSingle(int Id, string userId);

    IDataPost AdminDeleteSingle(int Id, string userId);





    IEnumerable<IPost> UserGetAll();

    IPost UserAddSingle(IAddPost data, string userId);

    IPost UserEditeSingle(IAddPost data, string userId);

    IPost UserGetSingle(int Id);

    IPost UserDeleteSingle(int Id, string userId);


    IPost AddImage(IDisplayAddImage image, string userId);


  }
}
