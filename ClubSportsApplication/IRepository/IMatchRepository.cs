using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IMatchRepository
  {
    List<Match> GetAllMarches();
    Match GetMarch(int Id);

    Match AddMarch(Match match);
    Match EditMarch(Match match);
  }
}
