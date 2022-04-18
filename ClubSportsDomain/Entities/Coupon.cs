using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class Coupon : BaseDataEntity
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public int CouponTypeId { get; set; }

    public int Unit { get; set; }

    public DateTime ExpiryDate { get; set; }


    public int UseCount { get; set; }
    public bool isActive { get; set; }


  }
}
