using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.DisplayEntity
{
  public class AddDisplayBasicDetails
  {

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
