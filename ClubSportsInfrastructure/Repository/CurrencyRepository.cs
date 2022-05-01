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
  public class CurrencyRepository : ICurrencyRepository
  {

    private readonly ApplicationDbContext _db;
    public CurrencyRepository(ApplicationDbContext db)
    {
      _db = db;
    }

    public IDataCurrency AddCurrency(IDataCurrency currency)
    {
      _db.Currencies.Add((DataCurrency)currency);
      _db.SaveChanges();
      return currency;
    }

    public IDataCurrency EditCurrency(IDataCurrency currency)
    {
      _db.Currencies.Update((DataCurrency)currency);
      _db.SaveChanges();
      return currency;
    }

    public IEnumerable<IDataCurrency> GetAllCurrencies()
    {
      var data = _db.Currencies.OrderByDescending(m => m.DateUpdated);
      return data;
    }

    public IDataCurrency GetCurrency(int Id)
    {
      var data = _db.Currencies.Where(m => m.Id == Id).FirstOrDefault();
      return data; 
    }
  }
}
