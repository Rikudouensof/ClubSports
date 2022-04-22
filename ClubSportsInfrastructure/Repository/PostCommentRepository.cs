using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class PostCommentRepository : IPostCommentRepository
  {
    public PostComment AddPostComment(PostComment postComment)
    {
      throw new NotImplementedException();
    }

    public PostComment EditPostComment(PostComment postComment)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<PostComment> GetAllPostComments()
    {
      throw new NotImplementedException();
    }

    public PostComment GetPostComment(int Id)
    {
      throw new NotImplementedException();
    }
  }
}
