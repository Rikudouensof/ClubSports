using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IPostCommentRepository
  {
    IEnumerable<PostComment> GetAllPostComments();
    PostComment GetPostComment(int Id);

    PostComment AddPostComment(PostComment postComment);
    PostComment EditPostComment(PostComment postComment);
  }
}
