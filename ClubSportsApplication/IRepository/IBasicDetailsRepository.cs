using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IBasicDetailsRepository
  {
    List<BasicDetails> GetAllBasicDetails();

    BasicDetails AddBasicDetail(BasicDetails basicDetail);

    BasicDetails basicDetails(BasicDetails basicDetail);

    BasicDetails GetSingleBasicDetail(int Id);
  }



  



 



  



 



  
 


  


 

 


 



  


 

 


 

 

 

 


 

 


  


 


}
