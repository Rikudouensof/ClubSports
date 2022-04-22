namespace ClubSportsDomain.EntityInterface
{
  public interface IMatchResult
  {
    int AwayClearances { get; set; }
    int AwayCorners { get; set; }
    int AwayFormationId { get; set; }
    int AwayFoulsConceded { get; set; }
    int AwayGoal { get; set; }
    int AwayOffSides { get; set; }
    int AwayPossesion { get; set; }
    int AwayRedCards { get; set; }
    int AwayShots { get; set; }
    int AwayShotsOnTarget { get; set; }
    int AwayTackles { get; set; }
    int AwayTouches { get; set; }
    int AwayYellowCards { get; set; }
    int HomeClearances { get; set; }
    int HomeCorners { get; set; }
    int HomeFormationId { get; set; }
    int HomeFoulsConceded { get; set; }
    int HomeGoal { get; set; }
    int HomeOffSides { get; set; }
    int HomePossesion { get; set; }
    int HomeRedCards { get; set; }
    int HomeShots { get; set; }
    int HomeShotsOnTarget { get; set; }
    int HomeTackles { get; set; }
    int HomeTouches { get; set; }
    int HomeYellowCards { get; set; }
    int Id { get; set; }
    int MatchId { get; set; }
  }
}