using ClubSportsApplication.IDataModels;
using ClubSportsDomain.DisplayEntity.Interface;
using ClubSportsDomain.EntityInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.IService
{
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
}
