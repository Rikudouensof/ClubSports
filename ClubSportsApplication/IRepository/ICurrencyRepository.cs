using ClubSportsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface ICurrencyRepository
  {
    List<Currency> GetAllCurrencies();
    Currency GetCurrency(int Id);

    Currency AddCurrency(Currency currency);
    Currency EditCurrency(Currency currency);
  }
}
