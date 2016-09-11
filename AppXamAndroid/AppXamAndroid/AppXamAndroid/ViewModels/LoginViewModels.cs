using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppXamAndroid.Models;
namespace AppXamAndroid.ViewModels
{
   public class LoginViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public User user { get; set; }
        public LoginViewModels()
        {
           user = new User();
        }
        public string Login
        {
            get { return user.Login; }
            set
            {
                if (user.Login != value)
                {
                    user.Login = value;
                    OnPropertyChanged("Login");
                }
            }
        }
        public string Password
        {
            get { return user.Password; }
            set
            {
                if (user.Password != value)
                {
                    user.Password = value;
                    OnPropertyChanged("Password");
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public static Task<bool> isLogin(string login,string pass)
        {
            return Task.Run(() =>
            {
                if (login.Length > 3 && pass.Length > 5)
                    return true;
                else
                    return false;
            });
                       
        }
    }
}
