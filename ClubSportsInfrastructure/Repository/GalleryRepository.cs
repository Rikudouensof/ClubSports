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
  public class GalleryRepository : IGalleryRepository
  {
    private readonly ApplicationDbContext _db;
    public GalleryRepository(ApplicationDbContext db)
    {
      _db = db;
    }



    public IDataGallery AddGallery(IDataGallery gallery)
    {
      _db.Galleries.Add((DataGallery)gallery);
      _db.SaveChanges();
      return gallery;
    }

    public IDataGallery EditGallery(IDataGallery gallery)
    {
      _db.Galleries.Update((DataGallery)gallery);
      _db.SaveChanges();
      return gallery;
    }

    public IEnumerable<IDataGallery> GetAllGalleries()
    {
      var data = _db.Galleries.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataGallery GetGallery(int Id)
    {
      var data = _db.Galleries.Where(m => m.Id == Id).FirstOrDefault();
      return data;
    }
  }
}
