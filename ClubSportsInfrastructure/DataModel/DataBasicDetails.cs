using ClubSportsApplication.IDataModels;
using ClubSportsDomain.BaseEntityInterface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.DataModel
{
  public class DataBasicDetails : IDataBasicDetails
  {

    public DataUser UpdatedBy { get; set; }
    public string AboutUs { get; set; }
    public string EmailAddress { get; set; }
    public string FacebookLink { get; set; }
    public int Id { get; set; }
    public string ImageLink { get; set; }
    public string LinkedInLink { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string PintrestLink { get; set; }
    public string TwitterLink { get; set; }
    public DateTime DateUpdated { get; set; }
    public bool isDeleted { get; set; }
    public string UpdatedById { get; set; }
  }



}
