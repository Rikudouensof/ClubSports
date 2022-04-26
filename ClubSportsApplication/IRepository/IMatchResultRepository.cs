using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IMatchResultRepository
  {
    IEnumerable<IDataMatchResult> GetAllMatchResult();
    IDataMatchResult GetMatchResult(int Id);

    IDataMatchResult AddMatchResult(IDataMatchResult matchResult);
    IDataMatchResult EditMatchResult(IDataMatchResult matchResult); 
  }
}
