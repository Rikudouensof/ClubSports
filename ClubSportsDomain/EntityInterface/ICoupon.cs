using System;

namespace ClubSportsDomain.EntityInterface
{
  public interface ICoupon
  {
    int CouponTypeId { get; set; }
    DateTime ExpiryDate { get; set; }
    int Id { get; set; }
    bool isActive { get; set; }
    string Name { get; set; }
    int Unit { get; set; }
    int UseCount { get; set; }
  }
}