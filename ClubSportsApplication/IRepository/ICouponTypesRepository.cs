using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ICouponTypesRepository
  {
    List<CouponTypes> GetAllCouponTypes();
    CouponTypes GetSingleCouponType(int Id);

    CouponTypes AddCouponType(CouponTypes coupontype);
    CouponTypes EditCouponType(CouponTypes coupontype);
  }
}
