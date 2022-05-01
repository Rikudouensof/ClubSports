using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
  public interface IBasicDetailsService
  {

    IEnumerable<IDataBasicDetails> AdminGetAllBasicDetails();

    IDataBasicDetails AdminAddBasicDetail(IDataBasicDetails basicDetail, string userId);

    IDataBasicDetails AdminAllbasicDetails(IDataBasicDetails basicDetail, string userId);

    IDataBasicDetails AdminGetSingleBasicDetail(int Id);

    IDataBasicDetails AdminDeleteSingleBasicDetail(int Id, string userId);





    IEnumerable<IBasicDetails> GetAllBasicDetails();

    IBasicDetails AddBasicDetail(IBasicDetails basicDetail, string userId);

    IBasicDetails basicDetails(IBasicDetails basicDetail, string userId);

    IBasicDetails GetSingleBasicDetail(int Id);

    IDataBasicDetails DeleteSingleBasicDetail(int Id, string userId);





  }

  public interface ICouponService
  {

    IEnumerable<IDataCoupon> AdminGetAll();

    IDataCoupon AdminAddSingle(IDataCoupon data, string userId);

    IDataCoupon AdminEditSingle(IDataCoupon data, string userId);

    IDataCoupon AdminGetSingle(int Id);

    IDataCoupon AdminDeleteSingle(int Id, string userId);





    IEnumerable<ICoupon> UserGetAll();

    ICoupon UserAddSingle(ICoupon data, string userId);

    ICoupon UserEditeSingle(ICoupon data, string userId);

    ICoupon UserGetSingle(int Id);

    ICoupon UserDeleteSingle(int Id, string userId);





  }

  public interface ICouponTypesService
  {

    IEnumerable<IDataCouponTypes> AdminGetAll();

    IDataCouponTypes AdminAddSingle(IDataCouponTypes data, string userId);

    IDataCouponTypes AdminEditSingle(IDataCouponTypes data, string userId);

    IDataCouponTypes AdminGetSingle(int Id);

    IDataCouponTypes AdminDeleteSingle(int Id, string userId);





    IEnumerable<ICouponTypes> UserGetAll();

    ICouponTypes UserAddSingle(ICouponTypes data, string userId);

    ICouponTypes UserEditeSingle(ICouponTypes data, string userId);

    ICouponTypes UserGetSingle(int Id);

    ICouponTypes UserDeleteSingle(int Id, string userId);





  }


  public interface ICurrencyService
  {

    IEnumerable<IDataCurrency> AdminGetAll();

    IDataCurrency AdminAddSingle(IDataCurrency data, string userId);

    IDataCurrency AdminEditSingle(IDataCurrency data, string userId);

    IDataCurrency AdminGetSingle(int Id);

    IDataCurrency AdminDeleteSingle(int Id, string userId);





    IEnumerable<ICurrency> UserGetAll();

    ICurrency UserAddSingle(ICurrency data, string userId);

    ICurrency UserEditeSingle(ICurrency data, string userId);

    ICurrency UserGetSingle(int Id);

    ICurrency UserDeleteSingle(int Id, string userId);





  }


  public interface IGalleryService
  {

    IEnumerable<IDataGallery> AdminGetAll();

    IDataGallery AdminAddSingle(IDataGallery data, string userId);

    IDataGallery AdminEditSingle(IDataGallery data, string userId);

    IDataGallery AdminGetSingle(int Id);

    IDataGallery AdminDeleteSingle(int Id, string userId);





    IEnumerable<IGallery> UserGetAll();

    IGallery UserAddSingle(IGallery data, string userId);

    IGallery UserEditeSingle(IGallery data, string userId);

    IGallery UserGetSingle(int Id);

    IGallery UserDeleteSingle(int Id, string userId);





  }

  public interface IMarchFormationService
  {

    IEnumerable<IDataMatchFormation> AdminGetAll();

    IDataMatchFormation AdminAddSingle(IDataMatchFormation data, string userId);

    IDataMatchFormation AdminEditSingle(IDataMatchFormation data, string userId);

    IDataMatchFormation AdminGetSingle(int Id);

    IDataMatchFormation AdminDeleteSingle(int Id, string userId);





    IEnumerable<IMatchFormation> UserGetAll();

    IMatchFormation UserAddSingle(IMatchFormation data, string userId);

    IMatchFormation UserEditeSingle(IMatchFormation data, string userId);

    IMatchFormation UserGetSingle(int Id);

    IMatchFormation UserDeleteSingle(int Id, string userId);





  }


  public interface IMarchTicketService
  {

    IEnumerable<IDataMarchTicket> AdminGetAll();

    IDataMarchTicket AdminAddSingle(IDataMarchTicket data, string userId);

    IDataMarchTicket AdminEditSingle(IDataMarchTicket data, string userId);

    IDataMarchTicket AdminGetSingle(int Id);

    IDataMarchTicket AdminDeleteSingle(int Id, string userId);





    IEnumerable<IMarchTicket> UserGetAll();

    IMarchTicket UserAddSingle(IMarchTicket data, string userId);

    IMarchTicket UserEditeSingle(IMarchTicket data, string userId);

    IMarchTicket UserGetSingle(int Id);

    IMarchTicket UserDeleteSingle(int Id, string userId);





  }


  public interface IMarchTicketTypeService
  {

    IEnumerable<IDataMarchTicketType> AdminGetAll();

    IDataMarchTicketType AdminAddSingle(IDataMarchTicketType data, string userId);

    IDataMarchTicketType AdminEditSingle(IDataMarchTicketType data, string userId);

    IDataMarchTicketType AdminGetSingle(int Id);

    IDataMarchTicketType AdminDeleteSingle(int Id, string userId);





    IEnumerable<IMarchTicketType> UserGetAll();

    IMarchTicketType UserAddSingle(IMarchTicketType data, string userId);

    IMarchTicketType UserEditeSingle(IMarchTicketType data, string userId);

    IMarchTicketType UserGetSingle(int Id);

    IMarchTicketType UserDeleteSingle(int Id, string userId);





  }


  public interface IMarchService
  {

    IEnumerable<IDataMatch> AdminGetAll();

    IDataMatch AdminAddSingle(IDataMatch data, string userId);

    IDataMatch AdminEditSingle(IDataMatch data, string userId);

    IDataMatch AdminGetSingle(int Id);

    IDataMatch AdminDeleteSingle(int Id, string userId);





    IEnumerable<IMatch> UserGetAll();

    IMatch UserAddSingle(IMatch data, string userId);

    IMatch UserEditeSingle(IMatch data, string userId);

    IMatch UserGetSingle(int Id);

    IMatch UserDeleteSingle(int Id, string userId);





  }

  public interface IMarchResultService
  {

    IEnumerable<IDataMatchResult> AdminGetAll();

    IDataMatchResult AdminAddSingle(IDataMatchResult data, string userId);

    IDataMatchResult AdminEditSingle(IDataMatchResult data, string userId);

    IDataMatchResult AdminGetSingle(int Id);

    IDataMatchResult AdminDeleteSingle(int Id, string userId);





    IEnumerable<IMatchResult> UserGetAll();

    IMatchResult UserAddSingle(IMatchResult data, string userId);

    IMatchResult UserEditeSingle(IMatchResult data, string userId);

    IMatchResult UserGetSingle(int Id);

    IMatchResult UserDeleteSingle(int Id, string userId);





  }

  public interface IPostCategoryService
  {

    IEnumerable<IDataPostCategory> AdminGetAll();

    IDataPostCategory AdminAddSingle(IDataPostCategory data, string userId);

    IDataPostCategory AdminEditSingle(IDataPostCategory data, string userId);

    IDataPostCategory AdminGetSingle(int Id);

    IDataPostCategory AdminDeleteSingle(int Id, string userId);





    IEnumerable<IPostCategory> UserGetAll();

    IPostCategory UserAddSingle(IPostCategory data, string userId);

    IPostCategory UserEditeSingle(IPostCategory data, string userId);

    IPostCategory UserGetSingle(int Id);

    IPostCategory UserDeleteSingle(int Id, string userId);





  }


  public interface IPostCommentService
  {

    IEnumerable<IDataPostComment> AdminGetAll();

    IDataPostComment AdminAddSingle(IDataPostComment data, string userId);

    IDataPostComment AdminEditSingle(IDataPostComment data, string userId);

    IDataPostComment AdminGetSingle(int Id);

    IDataPostComment AdminDeleteSingle(int Id, string userId);





    IEnumerable<IPostComment> UserGetAll();

    IPostComment UserAddSingle(IPostComment data, string userId);

    IPostComment UserEditeSingle(IPostComment data, string userId);

    IPostComment UserGetSingle(int Id);

    IPostComment UserDeleteSingle(int Id, string userId);





  }


  public interface IPostService
  {

    IEnumerable<IDataPost> AdminGetAll();

    IDataPost AdminAddSingle(IDataPost data, string userId);

    IDataPost AdminEditSingle(IDataPost data, string userId);

    IDataPost AdminGetSingle(int Id);

    IDataPost AdminDeleteSingle(int Id, string userId);





    IEnumerable<IPost> UserGetAll();

    IPost UserAddSingle(IPost data, string userId);

    IPost UserEditeSingle(IPost data, string userId);

    IPost UserGetSingle(int Id);

    IPost UserDeleteSingle(int Id, string userId);





  }

  public interface IProductService
  {

    IEnumerable<IDataProduct> AdminGetAll();

    IDataProduct AdminAddSingle(IDataProduct data, string userId);

    IDataProduct AdminEditSingle(IDataProduct data, string userId);

    IDataProduct AdminGetSingle(int Id);

    IDataProduct AdminDeleteSingle(int Id, string userId);





    IEnumerable<IProduct> UserGetAll();

    IProduct UserAddSingle(IProduct data, string userId);

    IProduct UserEditeSingle(IProduct data, string userId);

    IProduct UserGetSingle(int Id);

    IProduct UserDeleteSingle(int Id, string userId);





  }


  //Here
  public interface ITeamJersyService
  {

    IEnumerable<IDataTeamJersy> AdminGetAll();

    IDataTeamJersy AdminAddSingle(IDataTeamJersy data, string userId);

    IDataTeamJersy AdminEditSingle(IDataTeamJersy data, string userId);

    IDataTeamJersy AdminGetSingle(int Id);

    IDataTeamJersy AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITeamJersy> UserGetAll(string userid);

    ITeamJersy UserAddSingle(ITeamJersy data, string userId);

    ITeamJersy UserEditeSingle(ITeamJersy data, string userId);

    ITeamJersy UserGetSingle(int Id, string userId);

    ITeamJersy UserDeleteSingle(int Id, string userId);





  }


  public interface ITeamMemberService
  {

    IEnumerable<IDataTeamMember> AdminGetAll();

    IDataTeamMember AdminAddSingle(IDataTeamMember data, string userId);

    IDataTeamMember AdminEditSingle(IDataTeamMember data, string userId);

    IDataTeamMember AdminGetSingle(int Id);

    IDataTeamMember AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITeamMember> UserGetAll(string userid);

    ITeamMember UserAddSingle(ITeamMember data, string userId);

    ITeamMember UserEditeSingle(ITeamMember data, string userId);

    ITeamMember UserGetSingle(int Id, string userId);

    ITeamMember UserDeleteSingle(int Id, string userId);





  }

  public interface ITeamService
  {

    IEnumerable<IDataTeam> AdminGetAll();

    IDataTeam AdminAddSingle(IDataTeam data, string userId);

    IDataTeam AdminEditSingle(IDataTeam data, string userId);

    IDataTeam AdminGetSingle(int Id);

    IDataTeam AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITeam> UserGetAll(string userid);

    ITeam UserAddSingle(ITeam data, string userId);

    ITeam UserEditeSingle(ITeam data, string userId);

    ITeam UserGetSingle(int Id, string userId);

    ITeam UserDeleteSingle(int Id, string userId);





  }

  public interface ITeamRoleService
  {

    IEnumerable<IDataTeamRole> AdminGetAll();

    IDataTeamRole AdminAddSingle(IDataTeamRole data, string userId);

    IDataTeamRole AdminEditSingle(IDataTeamRole data, string userId);

    IDataTeamRole AdminGetSingle(int Id);

    IDataTeamRole AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITeamRole> UserGetAll(string userid);

    ITeamRole UserAddSingle(ITeamRole data, string userId);

    ITeamRole UserEditeSingle(ITeamRole data, string userId);

    ITeamRole UserGetSingle(int Id, string userId);

    ITeamRole UserDeleteSingle(int Id, string userId);





  }

  public interface ITeamSponsorService
  {

    IEnumerable<IDataTeamSponsor> AdminGetAll();

    IDataTeamSponsor AdminAddSingle(IDataTeamSponsor data, string userId);

    IDataTeamSponsor AdminEditSingle(IDataTeamSponsor data, string userId);

    IDataTeamSponsor AdminGetSingle(int Id);

    IDataTeamSponsor AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITeamSponsor> UserGetAll(string userid);

    ITeamSponsor UserAddSingle(ITeamSponsor data, string userId);

    ITeamSponsor UserEditeSingle(ITeamSponsor data, string userId);

    ITeamSponsor UserGetSingle(int Id, string userId);

    ITeamSponsor UserDeleteSingle(int Id, string userId);





  }

  public interface ITestimonialService
  {

    IEnumerable<IDataTestimonial> AdminGetAll();

    IDataTestimonial AdminAddSingle(IDataTestimonial data, string userId);

    IDataTestimonial AdminEditSingle(IDataTestimonial data, string userId);

    IDataTestimonial AdminGetSingle(int Id);

    IDataTestimonial AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITestimonial> UserGetAll(string userid);

    ITestimonial UserAddSingle(ITestimonial data, string userId);

    ITestimonial UserEditeSingle(ITestimonial data, string userId);

    ITestimonial UserGetSingle(int Id, string userId);

    ITestimonial UserDeleteSingle(int Id, string userId);





  }

  public interface IVideoService
  {

    IEnumerable<IDataVideo> AdminGetAll();

    IDataVideo AdminAddSingle(IDataVideo data, string userId);

    IDataVideo AdminEditSingle(IDataVideo data, string userId);

    IDataVideo AdminGetSingle(int Id);

    IDataVideo AdminDeleteSingle(int Id, string userId);





    IEnumerable<IVideo> UserGetAll(string userid);

    IVideo UserAddSingle(IVideo data, string userId);

    IVideo UserEditeSingle(IVideo data, string userId);

    IVideo UserGetSingle(int Id, string userId);

    IVideo UserDeleteSingle(int Id, string userId);





  }


  public interface IVoteOptionsService
  {

    IEnumerable<IDataVoteOption> AdminGetAll();

    IDataVoteOption AdminAddSingle(IDataVoteOption data, string userId);

    IDataVoteOption AdminEditSingle(IDataVoteOption data, string userId);

    IDataVoteOption AdminGetSingle(int Id);

    IDataVoteOption AdminDeleteSingle(int Id, string userId);





    IEnumerable<IVoteOption> UserGetAll(string userid);

    IVoteOption UserAddSingle(IVoteOption data, string userId);

    IVoteOption UserEditeSingle(IVoteOption data, string userId);

    IVoteOption UserGetSingle(int Id, string userId);

    IVideo UserDeleteSingle(int Id, string userId);





  }

  public interface IVoteQuestionService
  {

    IEnumerable<IDataVoteQuestion> AdminGetAll();

    IDataVoteQuestion AdminAddSingle(IDataVoteQuestion data, string userId);

    IDataVoteQuestion AdminEditSingle(IDataVoteQuestion data, string userId);

    IDataVoteQuestion AdminGetSingle(int Id);

    IDataVoteQuestion AdminDeleteSingle(int Id, string userId);





    IEnumerable<IVoteQuestion> UserGetAll(string userid);

    IVoteQuestion UserAddSingle(IVoteQuestion data, string userId);

    IVoteQuestion UserEditeSingle(IVoteQuestion data, string userId);

    IVoteQuestion UserGetSingle(int Id, string userId);

    IVoteQuestion UserDeleteSingle(int Id, string userId);





  }

  public interface IVoteService
  {

    IEnumerable<IDataVote> AdminGetAll();

    IDataVote AdminAddSingle(IDataVote data, string userId);

    IDataVote AdminEditSingle(IDataVote data, string userId);

    IDataVote AdminGetSingle(int Id);

    IDataVote AdminDeleteSingle(int Id, string userId);





    IEnumerable<IVote> UserGetAll(string userid);

    IVote UserAddSingle(IVote data, string userId);

    IVote UserEditeSingle(IVote data, string userId);

    IVote UserGetSingle(int Id, string userId);

    IVote UserDeleteSingle(int Id, string userId);





  }

}
