using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppXamAndroid.Droid.Implements;
using AppXamAndroid.Models;
using AppXamAndroid.Services;
using AppXamAndroid.ViewModels;


[assembly: Xamarin.Forms.Dependency(typeof(StudentsListImpl_Android))]
namespace AppXamAndroid.Droid.Implements
{
    public class StudentsListImpl_Android : AppXamAndroid.Services.IStudentsService
    {
       Task<List<Student>> IStudentsService.GetStudents()
        {
          return StudentsViewModel.getStudent();
        }

        
    }
}