using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.DisplayEntity.Interface
{
  public interface IDisplayAddImage
  {
    int? ValueId { get; set; }

    string MaybeUserId { get; set; }

    string ImageIs { get; set; }
  }
}
