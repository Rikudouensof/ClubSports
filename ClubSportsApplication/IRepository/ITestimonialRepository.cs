using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ITestimonialRepository
  {
    IEnumerable<IDataTestimonial> GetAllTestimonials();
    IDataTestimonial GetTestimonial(int Id);

    IDataTestimonial AddTestimonial(IDataTestimonial testimonial);
    IDataTestimonial EditTestimonial(IDataTestimonial testimonial);
  }
}
