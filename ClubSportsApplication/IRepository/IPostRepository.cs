using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IPostRepository
  {
    List<IDataPost> GetAllMatchResult();
    IDataPost GetMatchResult(int Id);

    IDataPost AddMatchResult(IDataPost match);
    IDataPost EditMatchResult(IDataPost match);
  }
}
