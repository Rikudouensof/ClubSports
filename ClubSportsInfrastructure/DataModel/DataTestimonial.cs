using ClubSportsDomain.BaseEntityInterface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.DataModel
{
  public class DataTestimonial : ITestimonial, IBaseDataEntity
  {
    public DataUser UpdatedBy { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    public int Rate { get; set; }
    public DateTime DateUpdated { get; set; }
    public bool isDeleted { get; set; }
    public string UpdatedById { get; set; }
  }
}
