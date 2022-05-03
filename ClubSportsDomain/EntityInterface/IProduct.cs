namespace ClubSportsDomain.EntityInterface
{
  public interface IProduct
  {
    int CurrencyId { get; set; }
    string Detail { get; set; }
    int Id { get; set; }
    string ImageLink { get; set; }
    string Name { get; set; }
    double Price { get; set; }

     bool isAvailabele { get; set; }
  }

  public interface IAddProduct
  {
    int CurrencyId { get; set; }
    string Detail { get; set; }
    int Id { get; set; }
    string ImageLink { get; set; }
    string Name { get; set; }
    double Price { get; set; }

    bool isAvailabele { get; set; }
  }
}