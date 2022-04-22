using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class Product : BaseDataEntity, IProduct
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public double Price { get; set; }

    public int CurrencyId { get; set; }

    public string ImageLink { get; set; }

    public string Detail { get; set; }
  }
}
