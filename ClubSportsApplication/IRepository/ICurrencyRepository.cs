using ClubSportsApplication.IDataModels;
using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ICurrencyRepository
  {
    IEnumerable<IDataCurrency> GetAllCurrencies();
    IDataCurrency GetCurrency(int Id);

    IDataCurrency AddCurrency(IDataCurrency currency);
    IDataCurrency EditCurrency(IDataCurrency currency);
  }
}
