using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IPostCommentRepository
  {
    IEnumerable<IDataPostComment> GetAllPostComments();
    IDataPostComment GetPostComment(int Id);

    IDataPostComment AddPostComment(IDataPostComment postComment);
    IDataPostComment EditPostComment(IDataPostComment postComment);
  }
}
