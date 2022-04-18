using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class Testimonial : BaseDataEntity
  {
    public int Id { get; set; }

    public int Rate { get; set; }

    public string Description { get; set; }
  }
}
