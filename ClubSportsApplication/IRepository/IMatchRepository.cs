using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IMatchRepository
  {
    IEnumerable<IDataMatch> GetAllMarches();
    IDataMatch GetMarch(int Id);

    IDataMatch AddMarch(IDataMatch match);
    IDataMatch EditMarch(IDataMatch match);
  }
}
