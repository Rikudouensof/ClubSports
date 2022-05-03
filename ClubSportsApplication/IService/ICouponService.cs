using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface ICouponService
  {

    IEnumerable<IDataCoupon> AdminGetAll();

    IDataCoupon AdminAddSingle(IDataCoupon data, string userId);

    IDataCoupon AdminEditSingle(IDataCoupon data, string userId);

    IDataCoupon AdminGetSingle(int Id);

    IDataCoupon AdminDeleteSingle(int Id, string userId);





    IEnumerable<ICoupon> UserGetAll(string userId);

    ICoupon UserAddSingle(ICoupon data, string userId);

    ICoupon UserEditeSingle(ICoupon data, string userId);

    ICoupon UserGetSingle(int Id, string userId);

    ICoupon UserDeleteSingle(int Id, string userId);





  }
}
