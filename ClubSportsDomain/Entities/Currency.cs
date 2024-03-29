﻿using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class Currency : BaseDataEntity, ICurrency
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string Sign { get; set; }

    public string ShortName { get; set; } 
  }
}
