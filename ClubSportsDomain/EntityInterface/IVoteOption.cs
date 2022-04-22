namespace ClubSportsDomain.EntityInterface
{
  public interface IVoteOption
  {
    int Id { get; set; }
    string Name { get; set; }
    int VoteQuestionId { get; set; }
  }
}