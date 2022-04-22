using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IGalleryRepository
  {
    List<Gallery> GetAllGalleries();
    Gallery GetGallery(int Id);

    Gallery AddGallery(Gallery gallery);
    Gallery EditGallery(Gallery gallery);
  }
}
