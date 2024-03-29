﻿using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class TeamJersy : BaseDataEntity, ITeamJersy
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string ImageLink { get; set; }

    public int TeamId { get; set; }

  }
}
