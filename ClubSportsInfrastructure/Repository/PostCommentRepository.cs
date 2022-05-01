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
  public class PostCommentRepository : IPostCommentRepository
  {

    private readonly ApplicationDbContext _db;
    public PostCommentRepository(ApplicationDbContext db)
    {
      _db = db;
    }
    public IDataPostComment AddPostComment(IDataPostComment postComment)
    {
      _db.PostComments.Add((DataPostComment)postComment);  
      _db.SaveChanges();
      return postComment;
    }

    public IDataPostComment EditPostComment(IDataPostComment postComment)
    {
      _db.PostComments.Update((DataPostComment)postComment);
      _db.SaveChanges();
      return postComment;
    }

    public IEnumerable<IDataPostComment> GetAllPostComments()
    {
      var data = _db.PostComments.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataPostComment GetPostComment(int Id)
    {
      var data = _db.PostComments.Where(m => m.Id == Id).FirstOrDefault();
      return data;
    }
  }
}
