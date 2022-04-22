using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class Testimonial : BaseDataEntity, ITestimonial
  {
    public int Id { get; set; }

    public int Rate { get; set; }

    public string Description { get; set; }
  }
}
  