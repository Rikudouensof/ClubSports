using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class Gallery : BaseDataEntity
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageLink { get; set; }

    public int Rating { get; set; }

    public string Description { get; set; }

  }
}
