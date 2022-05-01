using ClubSportsApplication.IDataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IRepository
{
  public interface IMarchFormationReposiory
  {
    IEnumerable<IDataMatchFormation> GetAllMarchFormations();
    IDataMatchFormation GetMarchFormation(int Id);

    IDataMatchFormation AddMarchFormation(IDataMatchFormation gallery);
    IDataMatchFormation EditMarchFormation(IDataMatchFormation gallery);
  }
}
