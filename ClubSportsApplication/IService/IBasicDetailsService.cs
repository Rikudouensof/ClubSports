using ClubSportsApplication.IDataModels;
using ClubSportsDomain.DisplayEntity;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.Entities;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface IBasicDetailsService
  {

    IEnumerable<IDataBasicDetails> AdminGetAllBasicDetails();

    IDataBasicDetails AdminAddBasicDetail(IDataBasicDetails basicDetail, string userId);

    IDataBasicDetails AdminAllbasicDetails(IDataBasicDetails basicDetail, string userId);

    IDataBasicDetails AdminGetSingleBasicDetail(int Id);

    IDataBasicDetails AdminAddImage(IDataBasicDetails data, string userId);

    IDataBasicDetails AdminDeleteSingleBasicDetail(int Id, string userId);





    IEnumerable<IBasicDetails> GetAllBasicDetails(string userId);

    IBasicDetails AddBasicDetail(IAddBasicDetails basicDetail, string userId);

    IBasicDetails basicDetails(IAddBasicDetails basicDetail, string userId);

    IBasicDetails GetSingleBasicDetail(int Id, string userId);

    IDataBasicDetails DeleteSingleBasicDetail(int Id, string userId);

    IBasicDetails AddImage(IDisplayAddImage image, string userId);





  }

 

 


  


  

 


 


 


  

 

 


 


 

  


  
 


  


 

 

  

  


  

 

 

}
