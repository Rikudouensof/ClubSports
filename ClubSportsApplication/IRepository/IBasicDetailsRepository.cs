using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IBasicDetailsRepository
  {
    IEnumerable<IDataBasicDetails> GetAllBasicDetails();

    IDataBasicDetails AddBasicDetail(IDataBasicDetails basicDetail);

    IDataBasicDetails basicDetails(IDataBasicDetails basicDetail);

    IDataBasicDetails GetSingleBasicDetail(int Id);
  }



  



  



  



 



  
 


  


 

 


 



  


 

 


 

 

 

 


 

 


  


 


}
