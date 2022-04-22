namespace ClubSportsDomain.EntityInterface
{
  public interface ICurrency
  {
    int Id { get; set; }
    string Name { get; set; }
    string ShortName { get; set; }
    string Sign { get; set; }
  }
}