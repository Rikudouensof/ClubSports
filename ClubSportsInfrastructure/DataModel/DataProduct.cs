using ClubSportsApplication.IDataModels;
using ClubSportsDomain.BaseEntityInterface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.DataModel
{
  public class DataProduct : IDataProduct
  {
    public DataCurrency Currency { get; set; }
    public DataUser UpdatedBy { get; set; }
    public int CurrencyId { get; set; }
    public string Detail { get; set; }
    public int Id { get; set; }
    public string ImageLink { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public DateTime DateUpdated { get; set; }
    public bool isDeleted { get; set; }
    public string UpdatedById { get; set; }
    public bool isAvailabele { get; set; }
  }

}
