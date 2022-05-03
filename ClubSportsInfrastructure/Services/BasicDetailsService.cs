using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IService;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Services
{
  public class BasicDetailsService : IBasicDetailsService
  {
    
    public BasicDetailsService()
    {

    }
    public IBasicDetails AddBasicDetail(IAddBasicDetails basicDetail, string userId)
    {
      throw new NotImplementedException();
    }

    public IBasicDetails AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataBasicDetails AdminAddBasicDetail(IDataBasicDetails basicDetail, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataBasicDetails AdminAddImage(IDataBasicDetails data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataBasicDetails AdminAllbasicDetails(IDataBasicDetails basicDetail, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataBasicDetails AdminDeleteSingleBasicDetail(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataBasicDetails> AdminGetAllBasicDetails()
    {
      throw new NotImplementedException();
    }

    public IDataBasicDetails AdminGetSingleBasicDetail(int Id)
    {
      throw new NotImplementedException();
    }

    public IBasicDetails basicDetails(IAddBasicDetails basicDetail, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataBasicDetails DeleteSingleBasicDetail(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IBasicDetails> GetAllBasicDetails(string userId)
    {
      throw new NotImplementedException();
    }

    public IBasicDetails GetSingleBasicDetail(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  

 

  
  

 
}
