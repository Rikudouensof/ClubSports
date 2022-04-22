using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IPostRepository
  {
    List<Post> GetAllMatchResult();
    Post GetMatchResult(int Id);

    Post AddMatchResult(Post match);
    Post EditMatchResult(Post match);
  }
}
