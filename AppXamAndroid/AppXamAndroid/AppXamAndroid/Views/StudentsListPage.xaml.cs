using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppXamAndroid.ViewModels;
using AppXamAndroid.Models;
using AppXamAndroid.Services;
using Xamarin.Forms;
using AppXamAndroid.Views;

namespace AppXamAndroid.Views
{
    public partial class StudentsListPage : ContentPage
    {
       

        public StudentsListPage()

        { 
            InitializeComponent();
           
            ObservableCollection<Student> StudentsListCollection = 
                new ObservableCollection<Student>(DependencyService.Get<IStudentsService>().GetStudents().GetAwaiter().GetResult());
            StudentsLV.ItemsSource = StudentsListCollection;
 
        }

    }
}
