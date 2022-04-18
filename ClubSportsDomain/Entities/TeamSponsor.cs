﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class TeamSponsor : BaseDataEntity
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string ImageLink { get; set; }

  }
}
