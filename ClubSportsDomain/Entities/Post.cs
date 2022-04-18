using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsDomain.Entities
{
  public class Post
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string ImageName { get; set; }

    public string Content { get; set; }

    public int PostCategoryId { get; set; }
  }
}
