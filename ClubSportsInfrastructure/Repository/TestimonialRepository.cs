using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class TestimonialRepository : ITestimonialRepository
  {
    public Testimonial AddTestimonial(Testimonial testimonial)
    {
      throw new NotImplementedException();
    }

    public Testimonial EditTestimonial(Testimonial testimonial)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Testimonial> GetAllTestimonials()
    {
      throw new NotImplementedException();
    }

    public Testimonial GetTestimonial(int Id)
    {
      throw new NotImplementedException();
    }
  }
}
