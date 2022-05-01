using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using ClubSportsInfrastructure.Data;
using ClubSportsInfrastructure.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class CouponRepository : ICouponRepository
  {

    private readonly ApplicationDbContext _db;
    public CouponRepository(ApplicationDbContext db)
    {
      _db = db;
    }
    public IDataCoupon AddCoupon(IDataCoupon coupon)
    {
      _db.Coupons.Add((DataCoupon)coupon);
      _db.SaveChanges();
      return coupon;
    }

    public IDataCoupon EditCoupon(IDataCoupon coupon)
    {
      _db.Coupons.Add((DataCoupon)coupon);
      _db.SaveChanges();
       return coupon;
    }

    public IEnumerable<IDataCoupon> GetAllCoupons()
    {
      var data = _db.Coupons.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataCoupon GetSingleCoupon(int Id)
    {
      var data = _db.Coupons.OrderByDescending(m => m.DateUpdated);
      return data;
    }
  }
}
