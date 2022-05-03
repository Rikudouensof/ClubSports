using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
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
}
