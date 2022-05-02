using ClubSportsDomain.DisplayEntity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.DisplayEntity
{
  internal class DisplayAddImage : IDisplayAddImage
  {
    public int? ValueId { get; set; }
    public string MaybeUserId { get; set; }
    public string ImageIs { get; set; }
  }
}
