﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class VoteOption : BaseDataEntity
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public int VoteQuestionId { get; set; }
  }
}
