using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppXamAndroid.Models;

namespace AppXamAndroid.Services
{
  public interface IAuthorizationService
    {
       Task<bool> Login(string login,string password);
  
    }
}
