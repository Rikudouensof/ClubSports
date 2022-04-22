using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.DataModel
{
  public class DataBasicDetails : BasicDetails
  {
  }

  public class DataCoupon : Coupon
  {

    public DataCouponType CouponType { get; set; }
  }

  public class DataCouponType : CouponTypes
  {

  }

  public class DataCurrency : Currency
  {

  }

  public class DataGallery : Gallery
  {
    public DataPostCategory PostCategory { get; set; }
  }

  public class DataMatchTicket : MarchTicket
  {
    public DataMatch Match { get; set; }

    public DataMatchTicketType MatchTicketType { get; set; }
  }

  public class DataMatchTicketType : MarchTicketType
  {

  }

  public class DataMatch : Match
  {
    public Team Hometeam { get; set; }
    public Team AwayTeam { get; set; }
  }

  public class DataMatchFormation : MatchFormation
  {

  }

  public class DataMatchResult : MatchResult
  {
    public DataMatch Match { get; set; }

    public DataMatchFormation HomeFormation { get; set; }

    public DataMatchFormation AwayFormation { get; set; }

  }

  public class DataPost : Post
  {
    public DataPostCategory PostCategory { get; set; }
  }

  public class DataPostCategory : PostCategory
  {

  }

  public class DataPostComment : PostComment
  {
    public DataPost Post { get; set; }
  }

  public class DataProduct : Product
  {
    public DataCurrency Currency { get; set; }
  }

  public class DataTeam : Team
  {

  }

  public class DataTeamJersy : TeamJersy
  {
    public DataTeam Team { get; set; }
  }

  public class DataTeamMember : TeamMember
  {
    public DataTeamRole Role { get; set; }
  }

  public class DataTeamRole : TeamRole
  {

  }

  public class DataTeamSponsor : TeamSponsor
  {

  }

  public class DataTestimonial : Testimonial
  {

  }

  public class DataVideos : Video
  {
    public DataPostCategory PostCategory { get; set; }
  }

  public class DataVote : Vote
  {
    public DataVoteOption VoteOption { get; set; }
    public DataVoteQuestion VoteQuestion { get; set; }
  }

  public class DataVoteOption : VoteOption
  {
    public DataVoteQuestion VoteQuestion { get; set; }

  }

  public class DataVoteQuestion : VoteQuestion
  {

  }
}
