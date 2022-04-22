using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class Vote : BaseDataEntity
  {

    public int Id { get; set; }

    public int VoteQuestionId { get; set; }

    public int VoteOptionId { get; set; }
  }
}
  