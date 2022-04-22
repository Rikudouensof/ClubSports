namespace ClubSportsDomain.EntityInterface
{
  public interface IVote
  {
    int Id { get; set; }
    int VoteOptionId { get; set; }
    int VoteQuestionId { get; set; }
  }
}