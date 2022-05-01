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
  public class PostRepository : IPostRepository
  {

    private readonly ApplicationDbContext _db;
    public PostRepository(ApplicationDbContext db)
    {
      _db = db;
    }


    public IDataPost AddMatchResult(IDataPost post)
    {
      _db.Posts.Add((DataPost)post);
      _db.SaveChanges();
      return post;
    }

    public IDataPost EditMatchResult(IDataPost post)
    {
      _db.Posts.Update((DataPost)post);
      _db.SaveChanges();
      return post;
    }

    public IEnumerable<IDataPost> GetAllMatchResult()
    {
      var data = _db.Posts.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataPost GetMatchResult(int Id)
    {
      var data = _db.Posts.OrderByDescending(m => m.DateUpdated);
      return data;
    }
  }
}
