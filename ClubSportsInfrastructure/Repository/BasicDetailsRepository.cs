using ClubSportsApplication.IDataModels;
using ClubSportsApplication.IRepository;
using ClubSportsDomain.Entities;
using ClubSportsInfrastructure.Data;
using ClubSportsInfrastructure.DataModel;
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

    public IDataBasicDetails AddBasicDetail(IDataBasicDetails basicDetail)
    {
      _db.BasicDetails.Add((DataBasicDetails)basicDetail);
      _db.SaveChanges();
      return basicDetail;
    }

    public IDataBasicDetails basicDetails(IDataBasicDetails basicDetail)
    {
      _db.BasicDetails.Update((DataBasicDetails)basicDetail);
      _db.SaveChanges();
      return basicDetail;
    }

    public IEnumerable<IDataBasicDetails> GetAllBasicDetails()
    {
      var basicDetails = _db.BasicDetails.OrderByDescending(m => m.DateUpdated);
      return basicDetails;
    }

    public IDataBasicDetails GetSingleBasicDetail(int Id)
    {
      var basicDetails = _db.BasicDetails.Where(m => m.Id == Id).FirstOrDefault();
      return basicDetails;
    }
  }
}
