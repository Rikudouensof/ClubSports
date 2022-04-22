using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class MatchResult : BaseDataEntity, IMatchResult
  {

    public int Id { get; set; }

    public int MatchId { get; set; }

    public int HomeGoal { get; set; }

    public int HomeFormationId { get; set; }

    public int HomePossesion { get; set; }

    public int HomeShotsOnTarget { get; set; }

    public int HomeShots { get; set; }

    public int HomeTouches { get; set; }

    public int HomeTackles { get; set; }

    public int HomeClearances { get; set; }

    public int HomeCorners { get; set; }

    public int HomeOffSides { get; set; }

    public int HomeYellowCards { get; set; }

    public int HomeRedCards { get; set; }

    public int HomeFoulsConceded { get; set; }


    public int AwayGoal { get; set; }

    public int AwayFormationId { get; set; }

    public int AwayPossesion { get; set; }

    public int AwayShotsOnTarget { get; set; }

    public int AwayShots { get; set; }

    public int AwayTouches { get; set; }

    public int AwayTackles { get; set; }

    public int AwayClearances { get; set; }

    public int AwayCorners { get; set; }

    public int AwayOffSides { get; set; }

    public int AwayYellowCards { get; set; }

    public int AwayRedCards { get; set; }

    public int AwayFoulsConceded { get; set; }
  }
}
