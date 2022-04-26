using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ICouponTypesRepository
  {
    IEnumerable<IDataCouponTypes> GetAllCouponTypes();
    IDataCouponTypes GetSingleCouponType(int Id);

    IDataCouponTypes AddCouponType(IDataCouponTypes coupontype);
    IDataCouponTypes EditCouponType(IDataCouponTypes coupontype);
  }
}
