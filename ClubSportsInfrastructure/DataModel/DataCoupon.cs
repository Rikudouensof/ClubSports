using ClubSportsApplication.IDataModels;
using ClubSportsDomain.BaseEntityInterface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.DataModel
{
  public class DataCoupon : IDataCoupon
  {

    public DataCouponType CouponType { get; set; }
    public DataUser UpdatedBy { get; set; }
    public int CouponTypeId { get; set; }
    public DateTime ExpiryDate { get; set; }
    public int Id { get; set; }
    public bool isActive { get; set; }
    public string Name { get; set; }
    public int Unit { get; set; }
    public int UseCount { get; set; }
    public DateTime DateUpdated { get; set; }
    public bool isDeleted { get; set; }
    public string UpdatedById { get; set; }
  }
}
