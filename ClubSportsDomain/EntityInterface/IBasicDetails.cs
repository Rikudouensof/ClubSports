namespace ClubSportsDomain.EntityInterface
{
  public interface IBasicDetails
  {
    string AboutUs { get; set; }
    string EmailAddress { get; set; }
    string FacebookLink { get; set; }
    int Id { get; set; }
    string ImageLink { get; set; }
    string LinkedInLink { get; set; }
    string Name { get; set; }
    string PhoneNumber { get; set; }
    string PintrestLink { get; set; }
    string TwitterLink { get; set; }
  }
}