using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IPostCategoryRepository
  {
    IEnumerable<IDataPostCategory> GetAllPostCategories();
    IDataPostCategory GetPostCategory(int Id);

    IDataPostCategory AddPostCategory(IDataPostCategory match);
    IDataPostCategory EditPostCategory(IDataPostCategory match);
  }
}
