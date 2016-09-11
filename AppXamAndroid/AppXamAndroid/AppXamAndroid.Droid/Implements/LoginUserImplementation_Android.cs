using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppXamAndroid.Droid.Implements;

using AppXamAndroid.Services;
using AppXamAndroid.ViewModels;

[assembly: Xamarin.Forms.Dependency(typeof(LoginUserImplementation_Android))]
namespace AppXamAndroid.Droid.Implements
{
    public class LoginUserImplementation_Android : AppXamAndroid.Services.IAuthorizationService
    {


     Task<bool> IAuthorizationService.Login(string login, string password)
        {

        return  LoginViewModels.isLogin(login,password);     
            
        }
    }
}