using ClubSportsDomain.BaseEntityInterface;
using ClubSportsDomain.EntityInterface;
using System;


namespace ClubSportsInfrastructure.DataModel
{
  public class DataCurrency : ICurrency, IBaseDataEntity
  {
    public DataUser UpdatedBy { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public string ShortName { get; set; }
    public string Sign { get; set; }
    public DateTime DateUpdated { get; set; }
    public bool isDeleted { get; set; }
    public string UpdatedById { get; set; }
  }
}
