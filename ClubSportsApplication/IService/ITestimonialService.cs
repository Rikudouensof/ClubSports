using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface ITestimonialService
  {

    IEnumerable<IDataTestimonial> AdminGetAll();

    IDataTestimonial AdminAddSingle(IDataTestimonial data, string userId);

    IDataTestimonial AdminEditSingle(IDataTestimonial data, string userId);

    IDataTestimonial AdminGetSingle(int Id);

    IDataTestimonial AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITestimonial> UserGetAll(string userid);

    ITestimonial UserAddSingle(ITestimonial data, string userId);

    ITestimonial UserEditeSingle(ITestimonial data, string userId);

    ITestimonial UserGetSingle(int Id, string userId);

    ITestimonial UserDeleteSingle(int Id, string userId);





  }
}
