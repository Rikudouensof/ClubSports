using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ICouponRepository
  {
    IEnumerable<IDataCoupon> GetAllCoupons();
    IDataCoupon GetSingleCoupon(int Id);

    IDataCoupon AddCoupon(IDataCoupon coupon);
    IDataCoupon EditCoupon(IDataCoupon coupon);
  }
}
