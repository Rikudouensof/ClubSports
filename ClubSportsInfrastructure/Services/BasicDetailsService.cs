using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IService;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Services
{
  public class BasicDetailsService : IBasicDetailsService
  {
    public IBasicDetails AddBasicDetail(IAddBasicDetails basicDetail, string userId)
    {
      throw new NotImplementedException();
    }

    public IBasicDetails AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataBasicDetails AdminAddBasicDetail(IDataBasicDetails basicDetail, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataBasicDetails AdminAddImage(IDataBasicDetails data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataBasicDetails AdminAllbasicDetails(IDataBasicDetails basicDetail, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataBasicDetails AdminDeleteSingleBasicDetail(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataBasicDetails> AdminGetAllBasicDetails()
    {
      throw new NotImplementedException();
    }

    public IDataBasicDetails AdminGetSingleBasicDetail(int Id)
    {
      throw new NotImplementedException();
    }

    public IBasicDetails basicDetails(IAddBasicDetails basicDetail, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataBasicDetails DeleteSingleBasicDetail(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IBasicDetails> GetAllBasicDetails(string userId)
    {
      throw new NotImplementedException();
    }

    public IBasicDetails GetSingleBasicDetail(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class CouponService : ICurrencyService
  {
    public IDataCoupon AdminAddSingle(IDataCoupon data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataCoupon AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataCoupon AdminEditSingle(IDataCoupon data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataCoupon> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataCoupon AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ICoupon UserAddSingle(ICoupon data, string userId)
    {
      throw new NotImplementedException();
    }

    public ICoupon UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ICoupon UserEditeSingle(ICoupon data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ICoupon> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public ICoupon UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class CurrencyService : ICurrencyService
  {
    public IDataCoupon AdminAddSingle(IDataCoupon data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataCurrency AdminAddSingle(IDataCurrency data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataCoupon AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataCoupon AdminEditSingle(IDataCoupon data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataCurrency AdminEditSingle(IDataCurrency data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataCoupon> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataCoupon AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ICoupon UserAddSingle(ICoupon data, string userId)
    {
      throw new NotImplementedException();
    }

    public ICurrency UserAddSingle(ICurrency data, string userId)
    {
      throw new NotImplementedException();
    }

    public ICoupon UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ICoupon UserEditeSingle(ICoupon data, string userId)
    {
      throw new NotImplementedException();
    }

    public ICurrency UserEditeSingle(ICurrency data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ICoupon> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public ICoupon UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    IDataCurrency ICurrencyService.AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    IEnumerable<IDataCurrency> ICurrencyService.AdminGetAll()
    {
      throw new NotImplementedException();
    }

    IDataCurrency ICurrencyService.AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    ICurrency ICurrencyService.UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    IEnumerable<ICurrency> ICurrencyService.UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    ICurrency ICurrencyService.UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class GalleryService : IGalleryService
  {
    public IGallery AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataGallery AdminAddSingle(IDataGallery data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataGallery AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataGallery AdminEditSingle(IDataGallery data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataGallery> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataGallery AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IGallery UserAddSingle(IAddGallery data, string userId)
    {
      throw new NotImplementedException();
    }

    public IGallery UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IGallery UserEditeSingle(IAddGallery data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IGallery> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IGallery UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class MarchFormationService : IMarchFormationService
  {
    public IDataMatchFormation AdminAddSingle(IDataMatchFormation data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMatchFormation AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMatchFormation AdminEditSingle(IDataMatchFormation data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataMatchFormation> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataMatchFormation AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IMatchFormation UserAddSingle(IMatchFormation data, string userId)
    {
      throw new NotImplementedException();
    }

    public IMatchFormation UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IMatchFormation UserEditeSingle(IMatchFormation data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IMatchFormation> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IMatchFormation UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }


  public class MarchResultService : IMarchResultService
  {
    public IDataMatchResult AdminAddSingle(IDataMatchResult data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMatchResult AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMatchResult AdminEditSingle(IDataMatchResult data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataMatchResult> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataMatchResult AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IMatchResult UserAddSingle(IMatchResult data, string userId)
    {
      throw new NotImplementedException();
    }

    public IMatchResult UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IMatchResult UserEditeSingle(IMatchResult data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IMatchResult> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IMatchResult UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class MarchService : IMarchService
  {
    public IDataMatch AdminAddSingle(IDataMatch data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMatch AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMatch AdminEditSingle(IDataMatch data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataMatch> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataMatch AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IMatch UserAddSingle(IMatch data, string userId)
    {
      throw new NotImplementedException();
    }

    public IMatch UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IMatch UserEditeSingle(IMatch data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IMatch> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IMatch UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class MarchTicketService : IMarchTicketService
  {
    public IDataMarchTicket AdminAddSingle(IDataMarchTicket data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMarchTicket AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMarchTicket AdminEditSingle(IDataMarchTicket data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataMarchTicket> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataMarchTicket AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IMarchTicket UserAddSingle(IMarchTicket data, string userId)
    {
      throw new NotImplementedException();
    }

    public IMarchTicket UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IMarchTicket UserEditeSingle(IMarchTicket data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IMarchTicket> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IMarchTicket UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class MarchTicketTypeService : IMarchTicketTypeService
  {
    public IDataMarchTicketType AdminAddSingle(IDataMarchTicketType data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMarchTicketType AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataMarchTicketType AdminEditSingle(IDataMarchTicketType data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataMarchTicketType> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataMarchTicketType AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IMarchTicketType UserAddSingle(IMarchTicketType data, string userId)
    {
      throw new NotImplementedException();
    }

    public IMarchTicketType UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IMarchTicketType UserEditeSingle(IMarchTicketType data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IMarchTicketType> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IMarchTicketType UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class PostCategoryService : IPostCategoryService
  {
    public IDataPostCategory AdminAddSingle(IDataPostCategory data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPostCategory AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPostCategory AdminEditSingle(IDataPostCategory data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataPostCategory> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataPostCategory AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IPostCategory UserAddSingle(IPostCategory data, string userId)
    {
      throw new NotImplementedException();
    }

    public IPostCategory UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IPostCategory UserEditeSingle(IPostCategory data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IPostCategory> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IPostCategory UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class PostCommentService : IPostCommentService
  {
    public IDataPostComment AdminAddSingle(IDataPostComment data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPostComment AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPostComment AdminEditSingle(IDataPostComment data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataPostComment> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataPostComment AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IPostComment UserAddSingle(IAddPostComment data, string userId)
    {
      throw new NotImplementedException();
    }

    public IPostComment UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IPostComment UserEditeSingle(IAddPostComment data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IPostComment> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IPostComment UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class PostService : IPostService
  {
    public IPost AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPost AdminAddSingle(IDataPost data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPost AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPost AdminEditSingle(IDataPost data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataPost> AdminGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IDataPost AdminGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IPost UserAddSingle(IAddPost data, string userId)
    {
      throw new NotImplementedException();
    }

    public IPost UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IPost UserEditeSingle(IAddPost data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IPost> UserGetAll()
    {
      throw new NotImplementedException();
    }

    public IPost UserGetSingle(int Id)
    {
      throw new NotImplementedException();
    }
  }

  public class ProductService : IProductService
  {
    public IProduct AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataProduct AdminAddSingle(IDataProduct data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataProduct AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataProduct AdminEditSingle(IDataProduct data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataProduct> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataProduct AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IProduct UserAddSingle(IAddProduct data, string userId)
    {
      throw new NotImplementedException();
    }

    public IProduct UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IProduct UserEditeSingle(IAddProduct data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IProduct> UserGetAll(string userId)
    {
      throw new NotImplementedException();
    }

    public IProduct UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class TeamJerseyService : ITeamJersyService
  {
    public ITeamJersy AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamJersy AdminAddSingle(IDataTeamJersy data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamJersy AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamJersy AdminEditSingle(IDataTeamJersy data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataTeamJersy> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataTeamJersy AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ITeamJersy UserAddSingle(IAddTeamJersy data, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamJersy UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamJersy UserEditeSingle(IAddTeamJersy data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ITeamJersy> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public ITeamJersy UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class TeamMemberService : ITeamMemberService
  {
    public ITeamMember AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamMember AdminAddSingle(IDataTeamMember data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamMember AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamMember AdminEditSingle(IDataTeamMember data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataTeamMember> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataTeamMember AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ITeamMember UserAddSingle(IAddTeamMember data, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamMember UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamMember UserEditeSingle(IAddTeamMember data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ITeamMember> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public ITeamMember UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class TeamRoleService : ITeamRoleService
  {
    public IDataTeamRole AdminAddSingle(IDataTeamRole data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamRole AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamRole AdminEditSingle(IDataTeamRole data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataTeamRole> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataTeamRole AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ITeamRole UserAddSingle(ITeamRole data, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamRole UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamRole UserEditeSingle(ITeamRole data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ITeamRole> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public ITeamRole UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class TeamService : ITeamService
  {
    public ITeam AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeam AdminAddSingle(IDataTeam data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeam AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeam AdminEditSingle(IDataTeam data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataTeam> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataTeam AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ITeam UserAddSingle(IAddTeam data, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeam UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeam UserEditeSingle(IAddTeam data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ITeam> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public ITeam UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class TeamSponsorService : ITeamSponsorService
  {
    public ITeamSponsor AddImage(IDisplayAddImage image, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamSponsor AdminAddSingle(IDataTeamSponsor data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamSponsor AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTeamSponsor AdminEditSingle(IDataTeamSponsor data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataTeamSponsor> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataTeamSponsor AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ITeamSponsor UserAddSingle(IAddTeamSponsor data, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamSponsor UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ITeamSponsor UserEditeSingle(IAddTeamSponsor data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ITeamSponsor> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public ITeamSponsor UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class TestimonialService : ITestimonialService
  {
    public IDataTestimonial AdminAddSingle(IDataTestimonial data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTestimonial AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataTestimonial AdminEditSingle(IDataTestimonial data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataTestimonial> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataTestimonial AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public ITestimonial UserAddSingle(ITestimonial data, string userId)
    {
      throw new NotImplementedException();
    }

    public ITestimonial UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public ITestimonial UserEditeSingle(ITestimonial data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ITestimonial> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public ITestimonial UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class VideoService : IVideoService
  {
    public IVideo AddVideo(IDisplayAddImage video, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVideo AdminAddSingle(IDataVideo data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVideo AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVideo AdminEditSingle(IDataVideo data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataVideo> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataVideo AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IVideo UserAddSingle(IAddVideo data, string userId)
    {
      throw new NotImplementedException();
    }

    public IVideo UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IVideo UserEditeSingle(IAddVideo data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IVideo> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public IVideo UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class VoteOptionsService : IVoteOptionsService
  {
    public IDataVoteOption AdminAddSingle(IDataVoteOption data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVoteOption AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVoteOption AdminEditSingle(IDataVoteOption data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataVoteOption> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataVoteOption AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IVoteOption UserAddSingle(IVoteOption data, string userId)
    {
      throw new NotImplementedException();
    }

    public IVideo UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IVoteOption UserEditeSingle(IVoteOption data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IVoteOption> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public IVoteOption UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class VoteQuestionService : IVoteOptionsService
  {
    public IDataVoteOption AdminAddSingle(IDataVoteOption data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVoteOption AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVoteOption AdminEditSingle(IDataVoteOption data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataVoteOption> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataVoteOption AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IVoteOption UserAddSingle(IVoteOption data, string userId)
    {
      throw new NotImplementedException();
    }

    public IVideo UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IVoteOption UserEditeSingle(IVoteOption data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IVoteOption> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public IVoteOption UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }

  public class VoteService : IVoteServices
  {
    public IDataVote AdminAddSingle(IDataVote data, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVote AdminDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IDataVote AdminEditSingle(IDataVote data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataVote> AdminGetAll()
    {
      throw new NotImplementedException();
    }

    public IDataVote AdminGetSingle(int Id)
    {
      throw new NotImplementedException();
    }

    public IVote UserAddSingle(IVote data, string userId)
    {
      throw new NotImplementedException();
    }

    public IVote UserDeleteSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }

    public IVote UserEditeSingle(IVote data, string userId)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IVote> UserGetAll(string userid)
    {
      throw new NotImplementedException();
    }

    public IVote UserGetSingle(int Id, string userId)
    {
      throw new NotImplementedException();
    }
  }
}
