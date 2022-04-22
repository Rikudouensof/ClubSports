using ClubSportsDomain.BaseEntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class BaseDataEntity : IBaseDataEntity
  {
    public DateTime DateUpdated { get; set; }

    public string UpdatedById { get; set; }

    public bool isDeleted { get; set; }

  }
}
