using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface ICouponTypesService
  {

    IEnumerable<IDataCouponTypes> AdminGetAll();

    IDataCouponTypes AdminAddSingle(IDataCouponTypes data, string userId);

    IDataCouponTypes AdminEditSingle(IDataCouponTypes data, string userId);

    IDataCouponTypes AdminGetSingle(int Id);

    IDataCouponTypes AdminDeleteSingle(int Id, string userId);





    IEnumerable<ICouponTypes> UserGetAll(string userId);

    ICouponTypes UserAddSingle(ICouponTypes data, string userId);

    ICouponTypes UserEditeSingle(ICouponTypes data, string userId);

    ICouponTypes UserGetSingle(int Id, string userId);

    ICouponTypes UserDeleteSingle(int Id, string userId);





  }
}
