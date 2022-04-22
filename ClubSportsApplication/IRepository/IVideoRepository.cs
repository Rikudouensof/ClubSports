using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IVideoRepository
  {
    IEnumerable<Video> GetAllVideos();
    Video GetVideo(int Id);

    Video AddVideo(Video video);
    Video EditVideo(Video video);
  }
}
