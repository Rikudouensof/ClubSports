using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IMatchResultRepository
  {
    List<MatchResult> GetAllMatchResult();
    MatchResult GetMatchResult(int Id);

    MatchResult AddMatchResult(MatchResult match);
    MatchResult EditMatchResult(MatchResult match); 
  }
}
