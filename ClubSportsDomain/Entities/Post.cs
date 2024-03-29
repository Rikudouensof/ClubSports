﻿using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class Post : BaseDataEntity, IPost
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string ImageLink { get; set; }

    public string Content { get; set; }

    public int PostCategoryId { get; set; }
  }
}
 