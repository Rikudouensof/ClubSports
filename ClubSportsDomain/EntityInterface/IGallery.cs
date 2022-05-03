namespace ClubSportsDomain.EntityInterface
{
  public interface IGallery
  {
    string Description { get; set; }
    int Id { get; set; }
    string ImageLink { get; set; }
    string Name { get; set; }
    int PostCategoryId { get; set; }
    int Rating { get; set; }
  }


  public interface IAddGallery
  {
    string Description { get; set; }
    int Id { get; set; }
    string Name { get; set; }
    int PostCategoryId { get; set; }
    int Rating { get; set; }
  }
}