using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface IPostCommentService
  {

    IEnumerable<IDataPostComment> AdminGetAll();

    IDataPostComment AdminAddSingle(IDataPostComment data, string userId);

    IDataPostComment AdminEditSingle(IDataPostComment data, string userId);

    IDataPostComment AdminGetSingle(int Id);

    IDataPostComment AdminDeleteSingle(int Id, string userId);





    IEnumerable<IPostComment> UserGetAll(string userId);

    IPostComment UserAddSingle(IAddPostComment data, string userId);

    IPostComment UserEditeSingle(IAddPostComment data, string userId);

    IPostComment UserGetSingle(int Id, string userId);

    IPostComment UserDeleteSingle(int Id, string userId);





  }
}
