using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IPostCategoryRepository
  {
    IEnumerable<PostCategory> GetAllPostCategories();
    PostCategory GetPostCategory(int Id);

    PostCategory AddPostCategory(PostCategory match);
    PostCategory EditPostCategory(PostCategory match);
  }
}
