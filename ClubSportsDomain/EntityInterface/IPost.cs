namespace ClubSportsDomain.EntityInterface
{
  public interface IPost
  {
    string Content { get; set; }
    int Id { get; set; }
    string ImageLink { get; set; }
    string Name { get; set; }
    int PostCategoryId { get; set; }
  }

  public interface IAddPost
  {
    string Content { get; set; }
    int Id { get; set; }
    string Name { get; set; }
    int PostCategoryId { get; set; }
  }
}