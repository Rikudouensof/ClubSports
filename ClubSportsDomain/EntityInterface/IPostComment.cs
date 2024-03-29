﻿namespace ClubSportsDomain.EntityInterface
{
  public interface IPostComment
  {
    string Content { get; set; }
    int Id { get; set; }
    string ImageName { get; set; }
    int PostId { get; set; }
  }

  public interface IAddPostComment
  {
    string Content { get; set; }
    int Id { get; set; }
    int PostId { get; set; }
  }
}


