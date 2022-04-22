namespace ClubSportsDomain.EntityInterface
{
  public interface ITeamJersy
  {
    string Description { get; set; }
    int Id { get; set; }
    string ImageLink { get; set; }
    string Name { get; set; }
    int TeamId { get; set; }
  }
}