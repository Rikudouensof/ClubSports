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
  public class VideoRepository : IVideoRepository
  {

    private readonly ApplicationDbContext _db;
    public VideoRepository(ApplicationDbContext db)
    {
      _db = db;
    }


    public IDataVideo AddVideo(IDataVideo video)
    {
      _db.Videos.Add((DataVideos)video);
      _db.SaveChanges();
      return video;
    }

    public IDataVideo EditVideo(IDataVideo video)
    {
      _db.Videos.Update((DataVideos)video);
      _db.SaveChanges();
      return video;
    }

    public IEnumerable<IDataVideo> GetAllVideos()
    {
      var data = _db.Videos.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataVideo GetVideo(int Id)
    {
      var data = _db.Videos.OrderByDescending(m => m.DateUpdated);
      return data;
    }
  }
}
