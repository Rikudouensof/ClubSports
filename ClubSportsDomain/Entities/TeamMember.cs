using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class TeamMember : BaseDataEntity
  {
    public int Id { get; set; }

    public string Name { get; set; }


    public DateTime DateOfBirth { get; set; }

    public double Weight { get; set; }

    public double Height { get; set; }

    public string PlaceOfBirth { get; set; }

    public string Citizenship { get; set; }

    public string Quote { get; set; }


    public string Description { get; set; }

    public int NumberOfMatches { get; set; }

    public int NumberOfGoals { get; set; }

    public int NumberOfPenalty { get; set; }

    public int NumberOfRedCards { get; set; }

    public int NumberOfYellowCards { get; set; }

    public string FacebookLink { get; set; }

    public string LinkedinLink { get; set; }

    public string InstagramLink { get; set; }

    public string TwitterLink { get; set; }


    public string RoleId { get; set; }

    public string ImageLink { get; set; }

    public string OverView { get; set; }

    public bool isActive { get; set; }

    public DateTime ContractEndDate { get; set; }
  }
}
