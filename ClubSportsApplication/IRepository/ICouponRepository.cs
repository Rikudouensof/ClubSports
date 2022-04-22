using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ICouponRepository
  {
    List<Coupon> GetAllCoupons();
    Coupon GetSingleCoupon(int Id);

    Coupon AddCoupon(Coupon coupon);
    Coupon EditCoupon(Coupon coupon);
  }
}
