using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppXamAndroid.Services;
using Xamarin.Forms;
using AppXamAndroid.Models;
using AppXamAndroid.ViewModels;
namespace AppXamAndroid.Views
{
    public partial class LoginPage : ContentPage
    {
        LoginViewModels loginviewmodels;
        
        public LoginPage()
        {
            InitializeComponent();
            loginviewmodels = new LoginViewModels();
            BindingContext = loginviewmodels;

        }
        void doLogin(object sender, EventArgs e)
        {

            if  (!String.IsNullOrEmpty(loginviewmodels.Login) && !String.IsNullOrEmpty(loginviewmodels.Password))
                {

              if(DependencyService.Get<IAuthorizationService>().Login(loginviewmodels.Login, loginviewmodels.Password).GetAwaiter().GetResult())
                {
                    Navigation.PushAsync(new StudentsListPage());
                }
                else
                {
                    DisplayAlert("Error", "Incorrect login or password", "OK");
                    loginviewmodels.Password = String.Empty;
                }
            }
        }
    }
}
