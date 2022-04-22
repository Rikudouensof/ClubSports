using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class PostCategoryRepository : IPostCategoryRepository
  {
    public PostCategory AddPostCategory(PostCategory match)
    {
      throw new NotImplementedException();
    }

    public PostCategory EditPostCategory(PostCategory match)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<PostCategory> GetAllPostCategories()
    {
      throw new NotImplementedException();
    }

    public PostCategory GetPostCategory(int Id)
    {
      throw new NotImplementedException();
    }
  }
}
