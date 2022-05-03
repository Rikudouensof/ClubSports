using ClubSportsApplication.IDataModels;
using ClubSportsDomain.DisplayEntity;
using ClubSportsDomain.DisplayEntity.Interface;
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

    IDataBasicDetails AdminAddImage(IDataBasicDetails data, string userId);

    IDataBasicDetails AdminDeleteSingleBasicDetail(int Id, string userId);





    IEnumerable<IBasicDetails> GetAllBasicDetails(string userId);

    IBasicDetails AddBasicDetail(IAddBasicDetails basicDetail, string userId);

    IBasicDetails basicDetails(IAddBasicDetails basicDetail, string userId);

    IBasicDetails GetSingleBasicDetail(int Id, string userId);

    IDataBasicDetails DeleteSingleBasicDetail(int Id, string userId);

    IBasicDetails AddImage(IDisplayAddImage image, string userId);





  }

  public interface ICouponService
  {

    IEnumerable<IDataCoupon> AdminGetAll();

    IDataCoupon AdminAddSingle(IDataCoupon data, string userId);

    IDataCoupon AdminEditSingle(IDataCoupon data, string userId);

    IDataCoupon AdminGetSingle(int Id);

    IDataCoupon AdminDeleteSingle(int Id, string userId);





    IEnumerable<ICoupon> UserGetAll(string userId);

    ICoupon UserAddSingle(ICoupon data, string userId);

    ICoupon UserEditeSingle(ICoupon data, string userId);

    ICoupon UserGetSingle(int Id, string userId);

    ICoupon UserDeleteSingle(int Id, string userId);





  }

  public interface ICouponTypesService
  {

    IEnumerable<IDataCouponTypes> AdminGetAll();

    IDataCouponTypes AdminAddSingle(IDataCouponTypes data, string userId);

    IDataCouponTypes AdminEditSingle(IDataCouponTypes data, string userId);

    IDataCouponTypes AdminGetSingle(int Id);

    IDataCouponTypes AdminDeleteSingle(int Id, string userId);





    IEnumerable<ICouponTypes> UserGetAll(string userId);

    ICouponTypes UserAddSingle(ICouponTypes data, string userId);

    ICouponTypes UserEditeSingle(ICouponTypes data, string userId);

    ICouponTypes UserGetSingle(int Id, string userId);

    ICouponTypes UserDeleteSingle(int Id, string userId);





  }


  public interface ICurrencyService
  {

    IEnumerable<IDataCurrency> AdminGetAll();

    IDataCurrency AdminAddSingle(IDataCurrency data, string userId);

    IDataCurrency AdminEditSingle(IDataCurrency data, string userId);

    IDataCurrency AdminGetSingle(int Id);

    IDataCurrency AdminDeleteSingle(int Id, string userId);





    IEnumerable<ICurrency> UserGetAll(string userId);

    ICurrency UserAddSingle(ICurrency data, string userId);

    ICurrency UserEditeSingle(ICurrency data, string userId);

    ICurrency UserGetSingle(int Id, string userId);

    ICurrency UserDeleteSingle(int Id, string userId);





  }


  public interface IGalleryService
  {

    IEnumerable<IDataGallery> AdminGetAll();

    IDataGallery AdminAddSingle(IDataGallery data, string userId);

    IDataGallery AdminEditSingle(IDataGallery data, string userId);

    IDataGallery AdminGetSingle(int Id);

    IDataGallery AdminDeleteSingle(int Id, string userId);





    IEnumerable<IGallery> UserGetAll(string userId);

    IGallery UserAddSingle(IAddGallery data, string userId);

    IGallery UserEditeSingle(IAddGallery data, string userId);

    IGallery UserGetSingle(int Id, string userId);

    IGallery UserDeleteSingle(int Id, string userId);

    IGallery AddImage(IDisplayAddImage image, string userId);


  }

  public interface IMarchFormationService
  {

    IEnumerable<IDataMatchFormation> AdminGetAll();

    IDataMatchFormation AdminAddSingle(IDataMatchFormation data, string userId);

    IDataMatchFormation AdminEditSingle(IDataMatchFormation data, string userId);

    IDataMatchFormation AdminGetSingle(int Id);

    IDataMatchFormation AdminDeleteSingle(int Id, string userId);





    IEnumerable<IMatchFormation> UserGetAll(string userId);

    IMatchFormation UserAddSingle(IMatchFormation data, string userId);

    IMatchFormation UserEditeSingle(IMatchFormation data, string userId);

    IMatchFormation UserGetSingle(int Id, string userId);

    IMatchFormation UserDeleteSingle(int Id, string userId);





  }


  public interface IMarchTicketService
  {

    IEnumerable<IDataMarchTicket> AdminGetAll();

    IDataMarchTicket AdminAddSingle(IDataMarchTicket data, string userId);

    IDataMarchTicket AdminEditSingle(IDataMarchTicket data, string userId);

    IDataMarchTicket AdminGetSingle(int Id);

    IDataMarchTicket AdminDeleteSingle(int Id, string userId);





    IEnumerable<IMarchTicket> UserGetAll(string userId);

    IMarchTicket UserAddSingle(IMarchTicket data, string userId);

    IMarchTicket UserEditeSingle(IMarchTicket data, string userId);

    IMarchTicket UserGetSingle(int Id, string userId);

    IMarchTicket UserDeleteSingle(int Id, string userId);





  }


  public interface IMarchTicketTypeService
  {

    IEnumerable<IDataMarchTicketType> AdminGetAll();

    IDataMarchTicketType AdminAddSingle(IDataMarchTicketType data, string userId);

    IDataMarchTicketType AdminEditSingle(IDataMarchTicketType data, string userId);

    IDataMarchTicketType AdminGetSingle(int Id);

    IDataMarchTicketType AdminDeleteSingle(int Id, string userId);





    IEnumerable<IMarchTicketType> UserGetAll(string userId);

    IMarchTicketType UserAddSingle(IMarchTicketType data, string userId);

    IMarchTicketType UserEditeSingle(IMarchTicketType data, string userId);

    IMarchTicketType UserGetSingle(int Id, string userId);

    IMarchTicketType UserDeleteSingle(int Id, string userId);





  }


  public interface IMarchService
  {

    IEnumerable<IDataMatch> AdminGetAll();

    IDataMatch AdminAddSingle(IDataMatch data, string userId);

    IDataMatch AdminEditSingle(IDataMatch data, string userId);

    IDataMatch AdminGetSingle(int Id);

    IDataMatch AdminDeleteSingle(int Id, string userId);





    IEnumerable<IMatch> UserGetAll(string userId);

    IMatch UserAddSingle(IMatch data, string userId);

    IMatch UserEditeSingle(IMatch data, string userId);

    IMatch UserGetSingle(int Id, string userId);

    IMatch UserDeleteSingle(int Id, string userId);





  }

  public interface IMarchResultService
  {

    IEnumerable<IDataMatchResult> AdminGetAll();

    IDataMatchResult AdminAddSingle(IDataMatchResult data, string userId);

    IDataMatchResult AdminEditSingle(IDataMatchResult data, string userId);

    IDataMatchResult AdminGetSingle(int Id);

    IDataMatchResult AdminDeleteSingle(int Id, string userId);





    IEnumerable<IMatchResult> UserGetAll(string userId);

    IMatchResult UserAddSingle(IMatchResult data, string userId);

    IMatchResult UserEditeSingle(IMatchResult data, string userId);

    IMatchResult UserGetSingle(int Id, string userId);

    IMatchResult UserDeleteSingle(int Id, string userId);





  }

  public interface IPostCategoryService
  {

    IEnumerable<IDataPostCategory> AdminGetAll();

    IDataPostCategory AdminAddSingle(IDataPostCategory data, string userId);

    IDataPostCategory AdminEditSingle(IDataPostCategory data, string userId);

    IDataPostCategory AdminGetSingle(int Id);

    IDataPostCategory AdminDeleteSingle(int Id, string userId);





    IEnumerable<IPostCategory> UserGetAll(string userId);

    IPostCategory UserAddSingle(IPostCategory data, string userId);

    IPostCategory UserEditeSingle(IPostCategory data, string userId);

    IPostCategory UserGetSingle(int Id, string userId);

    IPostCategory UserDeleteSingle(int Id, string userId);





  }


  public interface IPostCommentService
  {

    IEnumerable<IDataPostComment> AdminGetAll();

    IDataPostComment AdminAddSingle(IDataPostComment data, string userId);

    IDataPostComment AdminEditSingle(IDataPostComment data, string userId);

    IDataPostComment AdminGetSingle(int Id);

    IDataPostComment AdminDeleteSingle(int Id, string userId);





    IEnumerable<IPostComment> UserGetAll(string userId);

    IPostComment UserAddSingle(IAddPostComment data, string userId);

    IPostComment UserEditeSingle(IAddPostComment data, string userId);

    IPostComment UserGetSingle(int Id, string userId);

    IPostComment UserDeleteSingle(int Id, string userId);





  }


  public interface IPostService
  {

    IEnumerable<IDataPost> AdminGetAll(string userId);

    IDataPost AdminAddSingle(IDataPost data, string userId);

    IDataPost AdminEditSingle(IDataPost data, string userId);

    IDataPost AdminGetSingle(int Id, string userId);

    IDataPost AdminDeleteSingle(int Id, string userId);





    IEnumerable<IPost> UserGetAll();

    IPost UserAddSingle(IAddPost data, string userId);

    IPost UserEditeSingle(IAddPost data, string userId);

    IPost UserGetSingle(int Id);

    IPost UserDeleteSingle(int Id, string userId);


    IPost AddImage(IDisplayAddImage image, string userId);


  }

  public interface IProductService
  {

    IEnumerable<IDataProduct> AdminGetAll();

    IDataProduct AdminAddSingle(IDataProduct data, string userId);

    IDataProduct AdminEditSingle(IDataProduct data, string userId);

    IDataProduct AdminGetSingle(int Id);

    IDataProduct AdminDeleteSingle(int Id, string userId);





    IEnumerable<IProduct> UserGetAll(string userId);

    IProduct UserAddSingle(IAddProduct data, string userId);

    IProduct UserEditeSingle(IAddProduct data, string userId);

    IProduct UserGetSingle(int Id, string userId);

    IProduct UserDeleteSingle(int Id, string userId);

    IProduct AddImage(IDisplayAddImage image, string userId);




  }


  
  public interface ITeamJersyService
  {

    IEnumerable<IDataTeamJersy> AdminGetAll();

    IDataTeamJersy AdminAddSingle(IDataTeamJersy data, string userId);

    IDataTeamJersy AdminEditSingle(IDataTeamJersy data, string userId);

    IDataTeamJersy AdminGetSingle(int Id);

    IDataTeamJersy AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITeamJersy> UserGetAll(string userid);

    ITeamJersy UserAddSingle(IAddTeamJersy data, string userId);

    ITeamJersy UserEditeSingle(IAddTeamJersy data, string userId);

    ITeamJersy UserGetSingle(int Id, string userId);

    ITeamJersy UserDeleteSingle(int Id, string userId);

    ITeamJersy AddImage(IDisplayAddImage image, string userId);

  }


  public interface ITeamMemberService
  {

    IEnumerable<IDataTeamMember> AdminGetAll();

    IDataTeamMember AdminAddSingle(IDataTeamMember data, string userId);

    IDataTeamMember AdminEditSingle(IDataTeamMember data, string userId);

    IDataTeamMember AdminGetSingle(int Id);

    IDataTeamMember AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITeamMember> UserGetAll(string userid);

    ITeamMember UserAddSingle(IAddTeamMember data, string userId);

    ITeamMember UserEditeSingle(IAddTeamMember data, string userId);

    ITeamMember UserGetSingle(int Id, string userId);

    ITeamMember UserDeleteSingle(int Id, string userId);


    ITeamMember AddImage(IDisplayAddImage image, string userId);


  }

  public interface ITeamService
  {

    IEnumerable<IDataTeam> AdminGetAll();

    IDataTeam AdminAddSingle(IDataTeam data, string userId);

    IDataTeam AdminEditSingle(IDataTeam data, string userId);

    IDataTeam AdminGetSingle(int Id);

    IDataTeam AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITeam> UserGetAll(string userid);

    ITeam UserAddSingle(IAddTeam data, string userId);

    ITeam UserEditeSingle(IAddTeam data, string userId);

    ITeam UserGetSingle(int Id, string userId);

    ITeam UserDeleteSingle(int Id, string userId);

    ITeam AddImage(IDisplayAddImage image, string userId);




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

    ITeamSponsor UserAddSingle(IAddTeamSponsor data, string userId);

    ITeamSponsor UserEditeSingle(IAddTeamSponsor data, string userId);

    ITeamSponsor UserGetSingle(int Id, string userId);

    ITeamSponsor UserDeleteSingle(int Id, string userId);

    ITeamSponsor AddImage(IDisplayAddImage image, string userId);



  }

  public interface ITestimonialService
  {

    IEnumerable<IDataTestimonial> AdminGetAll();

    IDataTestimonial AdminAddSingle(IDataTestimonial data, string userId);

    IDataTestimonial AdminEditSingle(IDataTestimonial data, string userId);

    IDataTestimonial AdminGetSingle(int Id);

    IDataTestimonial AdminDeleteSingle(int Id, string userId);





    IEnumerable<ITestimonial> UserGetAll(string userid);

    ITestimonial UserAddSingle(IAddVideo data, string userId);

    ITestimonial UserEditeSingle(IAddVideo data, string userId);

    ITestimonial UserGetSingle(int Id, string userId);

    ITestimonial UserDeleteSingle(int Id, string userId);

    ITestimonial AddImage(IDisplayAddImage video, string userId);




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
