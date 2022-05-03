using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IService;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Services
{
  public class CouponService : ICurrencyService
  {
    public IDataCoupon AdminAddSingle(IDataCoupon data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataCurrency AdminAddSingle(IDataCurrency data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataCoupon AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataCoupon AdminEditSingle(IDataCoupon data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataCurrency AdminEditSingle(IDataCurrency data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataCoupon> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataCoupon AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ICoupon UserAddSingle(ICoupon data, string userId)
    {
      throw new NotImplementedException();
    }

    public ICurrency UserAddSingle(ICurrency data, string userId)
    {
      throw new NotImplementedException();
    }

    public ICoupon UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ICoupon UserEditeSingle(ICoupon data, string userId)
    {
      throw new NotImplementedException();
    }

    public ICurrency UserEditeSingle(ICurrency data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ICoupon> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public ICoupon UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    IDataCurrency ICurrencyService.AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    IEnumerable<IDataCurrency> ICurrencyService.AdminGetAll()
    {
      throw new NotImplementedException();
    }

    IDataCurrency ICurrencyService.AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    ICurrency ICurrencyService.UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    IEnumerable<ICurrency> ICurrencyService.UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    ICurrency ICurrencyService.UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
