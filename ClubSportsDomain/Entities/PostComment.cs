using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class PostComment : BaseDataEntity
  {
    public int Id { get; set; }

    public string ImageName { get; set; }

    public string Content { get; set; }

  }
}
