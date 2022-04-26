using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IGalleryRepository
  {
    IEnumerable<IDataGallery> GetAllGalleries();
    IDataGallery GetGallery(int Id);

    IDataGallery AddGallery(IDataGallery gallery);
    IDataGallery EditGallery(IDataGallery gallery);
  }
}
