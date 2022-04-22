using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class Video : BaseDataEntity
  {

    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string VideoLink { get; set; }

    public int PostCategoryId { get; set; }
  }
}
  