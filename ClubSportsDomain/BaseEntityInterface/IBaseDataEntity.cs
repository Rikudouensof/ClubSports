using System;

namespace ClubSportsDomain.BaseEntityInterface
{
  public interface IBaseDataEntity
  {
    DateTime DateUpdated { get; set; }
    bool isDeleted { get; set; }
    string UpdatedById { get; set; }
  }
}