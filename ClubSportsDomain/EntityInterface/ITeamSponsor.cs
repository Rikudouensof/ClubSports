﻿namespace ClubSportsDomain.EntityInterface
{
  public interface ITeamSponsor
  {
    int Id { get; set; }
    string ImageLink { get; set; }
    string Name { get; set; }
  }

  public interface IAddTeamSponsor
  {
    int Id { get; set; }
    string Name { get; set; }
  }
}