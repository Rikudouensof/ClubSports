using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IService;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.EntityInterface;

namespace ClubSportsInfrastructure.Services
{
  public class TestimonialService : ITestimonialService
  {
    public IDataTestimonial AdminAddSingle(IDataTestimonial data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTestimonial AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTestimonial AdminEditSingle(IDataTestimonial data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataTestimonial> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataTestimonial AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ITestimonial UserAddSingle(ITestimonial data, string userId)
    {
      throw new NotImplementedException();
    }

    public ITestimonial UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ITestimonial UserEditeSingle(ITestimonial data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ITestimonial> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public ITestimonial UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
