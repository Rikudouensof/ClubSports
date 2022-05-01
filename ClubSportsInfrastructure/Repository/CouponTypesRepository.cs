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


  public class CouponTypesRepository : ICouponTypesRepository
  {

    private readonly ApplicationDbContext _db;
    public CouponTypesRepository(ApplicationDbContext db)
    {
      _db = db;
    }

    public IDataCouponTypes AddCouponType(IDataCouponTypes coupontype)
    {
      _db.CouponTypes.Add((DataCouponType)coupontype);
      _db.SaveChanges();
      return coupontype;
    }

    public IDataCouponTypes EditCouponType(IDataCouponTypes coupontype)
    {
      _db.CouponTypes.Update((DataCouponType)coupontype);
      _db.SaveChanges();
      return coupontype;
    }

    public IEnumerable<IDataCouponTypes> GetAllCouponTypes()
    {
      var data = _db.CouponTypes.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataCouponTypes GetSingleCouponType(int Id)
    {
      var data = _db.CouponTypes.Where(m => m.Id == Id).FirstOrDefault();
      return data;
    }
  }
}
