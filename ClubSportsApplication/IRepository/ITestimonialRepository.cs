using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ITestimonialRepository
  {
    IEnumerable<Testimonial> GetAllTestimonials();
    Testimonial GetTestimonial(int Id);

    Testimonial AddTestimonial(Testimonial testimonial);
    Testimonial EditTestimonial(Testimonial testimonial);
  }
}
