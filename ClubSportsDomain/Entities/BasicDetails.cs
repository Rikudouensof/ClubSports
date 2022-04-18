using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class BasicDetails : BaseDataEntity
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string ImageLink { get; set; }

    public string FacebookLink { get; set; }

    public string PhoneNumber { get; set; }

    public string TwitterLink { get; set; }

    public string LinkedInLink { get; set; }

    public string PintrestLink { get; set; }

    public string EmailAddress { get; set; }

    public string AboutUs { get; set; }
  }
}
