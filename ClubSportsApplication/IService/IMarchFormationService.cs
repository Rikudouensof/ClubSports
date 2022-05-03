using ClubSportsApplication.IDataModels;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
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
}
