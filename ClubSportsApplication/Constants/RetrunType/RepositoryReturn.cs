using System;
using System.Collections.Generic;
using System.Text;

namespace ClubSportsApplication.Constants.RetrunType
{
  public class RepositoryReturn<T>
  {
     public bool isSucessful { get; set; }

     public T returnValue { get; set; }

    public string ErrorMesage { get; set; }
  }
}
