using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class BaseDataEntity
  {
    public DateTime DateUpdated { get; set; }

    public string UpdatedById { get; set; }

  }
}
