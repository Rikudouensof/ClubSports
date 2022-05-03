using System;

namespace ClubSportsDomain.EntityInterface
{
  public interface ITeamMember
  {
    string Citizenship { get; set; }
    DateTime ContractEndDate { get; set; }
    DateTime DateOfBirth { get; set; }
    string Description { get; set; }
    string FacebookLink { get; set; }
    double Height { get; set; }
    int Id { get; set; }
    string ImageLink { get; set; }
    string InstagramLink { get; set; }
    bool isActive { get; set; }
    string LinkedinLink { get; set; }
    string Name { get; set; }
    int NumberOfGoals { get; set; }
    int NumberOfMatches { get; set; }
    int NumberOfPenalty { get; set; }
    int NumberOfRedCards { get; set; }
    int NumberOfYellowCards { get; set; }
    string OverView { get; set; }
    string PlaceOfBirth { get; set; }
    string Quote { get; set; }
    string RoleId { get; set; }
    string TwitterLink { get; set; }
    double Weight { get; set; }
  }

  public interface IAddTeamMember
  {
    string Citizenship { get; set; }
    DateTime ContractEndDate { get; set; }
    DateTime DateOfBirth { get; set; }
    string Description { get; set; }
    string FacebookLink { get; set; }
    double Height { get; set; }
    int Id { get; set; }
    string InstagramLink { get; set; }
    bool isActive { get; set; }
    string LinkedinLink { get; set; }
    string Name { get; set; }
    int NumberOfGoals { get; set; }
    int NumberOfMatches { get; set; }
    int NumberOfPenalty { get; set; }
    int NumberOfRedCards { get; set; }
    int NumberOfYellowCards { get; set; }
    string OverView { get; set; }
    string PlaceOfBirth { get; set; }
    string Quote { get; set; }
    string RoleId { get; set; }
    string TwitterLink { get; set; }
    double Weight { get; set; }
  }
}