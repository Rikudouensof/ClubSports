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
  public class TestimonialRepository : ITestimonialRepository
  {

    private readonly ApplicationDbContext _db;
    public TestimonialRepository(ApplicationDbContext db)
    {
      _db = db;
    }
    public IDataTestimonial AddTestimonial(IDataTestimonial testimonial)
    {
      _db.Testimonials.Add((DataTestimonial)testimonial);
      _db.SaveChanges();
      return testimonial;
    }

    public IDataTestimonial EditTestimonial(IDataTestimonial testimonial)
    {
      _db.Testimonials.Update((DataTestimonial)testimonial);
      _db.SaveChanges();
      return testimonial;
    }

    public IEnumerable<IDataTestimonial> GetAllTestimonials()
    {
      var data = _db.Testimonials.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataTestimonial GetTestimonial(int Id)
    {
      var data = _db.Testimonials.OrderByDescending(m => m.DateUpdated).Where(m => m.Id == Id).FirstOrDefault(); ;
      return data;
    }
  }
}
