namespace ClubSportsDomain.EntityInterface
{
  public interface IVideo
  {
    string Description { get; set; }
    int Id { get; set; }
    string Name { get; set; }
    int PostCategoryId { get; set; }
    string VideoLink { get; set; }
  }
}