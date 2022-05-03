using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface IMarchService
  {

    IEnumerable<IDataMatch> AdminGetAll();

    IDataMatch AdminAddSingle(IDataMatch data, string userId);

    IDataMatch AdminEditSingle(IDataMatch data, string userId);

    IDataMatch AdminGetSingle(int Id);

    IDataMatch AdminDeleteSingle(int Id, string userId);





    IEnumerable<IMatch> UserGetAll(string userId);

    IMatch UserAddSingle(IMatch data, string userId);

    IMatch UserEditeSingle(IMatch data, string userId);

    IMatch UserGetSingle(int Id, string userId);

    IMatch UserDeleteSingle(int Id, string userId);





  }
}
