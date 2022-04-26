using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using ClubSportsInfrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSportsInfrastructure.Repository
{
  public class BasicDetailsRepository : IBasicDetailsRepository
  {

    private readonly ApplicationDbContext _db;
    public BasicDetailsRepository(ApplicationDbContext db)
    {
      _db = db;
    }
    
    public BasicDetails AddBasicDetail(BasicDetails basicDetail)
    {
      throw new NotImplementedException();
    }

    public BasicDetails basicDetails(BasicDetails basicDetail)
    {
      throw new NotImplementedException();
    }

    public List<BasicDetails> GetAllBasicDetails()
    {
      throw new NotImplementedException();
    }

    public BasicDetails GetSingleBasicDetail(int Id)
    {
      throw new NotImplementedException();
    }
  }
}
