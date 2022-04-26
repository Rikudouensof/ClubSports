using ClubSportsDomain.BaseEntityInterface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IDataModels
{
  public interface IDataBasicDetails : IBasicDetails, IBaseDataEntity
  {
  }

  public interface IDataCoupon : ICoupon, IBaseDataEntity
  {
  }



  public interface IDataCouponTypes : ICouponTypes, IBaseDataEntity
  {
  }

  public interface IDataCurrency : ICurrency, IBaseDataEntity
  {
  }

  public interface IDataGallery : IGallery, IBaseDataEntity
  {
  }

  public interface IDataMatch : IMatch, IBaseDataEntity
  {
  }

  public interface IDataMatchFormation : IMatchFormation, IBaseDataEntity
  {
  }

  public interface IDataMatchResult : IMatchResult, IBaseDataEntity
  {
  }

  public interface IDataMarchTicket : IMarchTicket, IBaseDataEntity
  {
  }

  public interface IDataMarchTicketType : IMarchTicketType, IBaseDataEntity
  {
  }

  public interface IDataPost : IPost, IBaseDataEntity
  {
  }

  public interface IDataPostCategory : IPostCategory, IBaseDataEntity
  {
  }

  public interface IDataPostComment : IPostComment, IBaseDataEntity
  {
  }

  public interface IDataProduct : IProduct, IBaseDataEntity
  {
  }

  public interface IDataTeam : ITeam, IBaseDataEntity
  {
  }

  public interface IDataTeamJersy : ITeamJersy, IBaseDataEntity
  {
  }

  public interface IDataTeamMember : ITeamMember, IBaseDataEntity
  {
  }

  public interface IDataTeamRole : ITeamRole, IBaseDataEntity
  {
  }

  public interface IDataTeamSponsor : ITeamSponsor, IBaseDataEntity
  {
  }

  public interface IDataTestimonial : ITestimonial, IBaseDataEntity
  {
  }

  public interface IDataVideo : IVideo, IBaseDataEntity
  {
  }

  public interface IDataVote : IVote, IBaseDataEntity
  {
  }

  public interface IDataVoteOption : IVoteOption, IBaseDataEntity
  {
  }

  public interface IDataVoteQuestion : IVoteQuestion, IBaseDataEntity
  {
  }


}
