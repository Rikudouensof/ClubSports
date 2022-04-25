using ClubSportsInfrastructure.DataModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsInfrastructure.Data
{
  public class ApplicationDbContext : IdentityDbContext<DataUser>
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<DataBasicDetails> BasicDetails { get; set; }
    public DbSet<DataCoupon> Coupons { get; set; }

    public DbSet<DataCurrency> Currencies { get; set; }
    public DbSet<DataCouponType> CouponTypes { get; set; }

    public DbSet<DataGallery> Galleries { get; set; }

    public DbSet<DataMatch> Matches { get; set; }

    public DbSet<DataMatchFormation> MatchFormations { get; set; }

    public DbSet<DataMatchResult> MatchResults { get; set; }

    public DbSet<DataMatchTicket> MatchTickets { get; set; }

    public DbSet<DataMatchTicketType> MatchTicketTypes { get; set; }

    public DbSet<DataPost> Posts { get; set; }

    public DbSet<DataPostCategory> PostCategories { get; set; }

    public DbSet<DataPostComment> PostComments { get; set; }

    public DbSet<DataProduct> SellableProducts { get; set; }

    public DbSet<DataTeam> Teams { get; set; }

    public DbSet<DataTeamJersy> TeamJersies { get; set; }

    public DbSet<DataTeamMember> TeamMembers { get; set; }

    public DbSet<DataTeamRole> TeamRoles { get; set; }

    public DbSet<DataTeamSponsor> TeamSponsors { get; set; }

    public DbSet<DataTestimonial> Testimonials { get; set; }

    public DbSet<DataVideos> Videos { get; set; }


    public DbSet<DataVote> Votes { get; set; }

    public DbSet<DataVoteOption> VoteOptions { get; set; }


    public DbSet<DataVoteQuestion> VoteQuestions { get; set; }



  }
}
