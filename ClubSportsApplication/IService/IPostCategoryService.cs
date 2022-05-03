using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface IPostCategoryService
  {

    IEnumerable<IDataPostCategory> AdminGetAll();

    IDataPostCategory AdminAddSingle(IDataPostCategory data, string userId);

    IDataPostCategory AdminEditSingle(IDataPostCategory data, string userId);

    IDataPostCategory AdminGetSingle(int Id);

    IDataPostCategory AdminDeleteSingle(int Id, string userId);





    IEnumerable<IPostCategory> UserGetAll(string userId);

    IPostCategory UserAddSingle(IPostCategory data, string userId);

    IPostCategory UserEditeSingle(IPostCategory data, string userId);

    IPostCategory UserGetSingle(int Id, string userId);

    IPostCategory UserDeleteSingle(int Id, string userId);





  }
}
