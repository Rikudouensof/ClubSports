using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using ClubSportsInfrastructure.Data;
using ClubSportsInfrastructure.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class PostCategoryRepository : IPostCategoryRepository
  {

    private readonly ApplicationDbContext _db;
    public PostCategoryRepository(ApplicationDbContext db)
    {
      _db = db;
    }
    public IDataPostCategory AddPostCategory(IDataPostCategory match)
    {
      _db.PostCategories.Add((DataPostCategory)match);
      _db.SaveChanges();
      return match;
    }

    public IDataPostCategory EditPostCategory(IDataPostCategory match)
    {
      _db.PostCategories.Add((DataPostCategory)match);
      _db.SaveChanges();
      return match;
    }

    public IEnumerable<IDataPostCategory> GetAllPostCategories()
    {
      var data = _db.PostCategories.OrderByDescending(m => m.DateUpdated);
      return data;
    }


    public IDataPostCategory GetPostCategory(int Id)
    {
      var data = _db.PostCategories.Where(m => m.Id == Id).FirstOrDefault();
      return data;
    }
  
  }
}
