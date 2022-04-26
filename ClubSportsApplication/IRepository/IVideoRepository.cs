using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IVideoRepository
  {
    IEnumerable<IDataVideo> GetAllVideos();
    IDataVideo GetVideo(int Id);

    IDataVideo AddVideo(IDataVideo video);
    IDataVideo EditVideo(IDataVideo video);
  }
}
