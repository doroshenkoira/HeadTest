using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppXamAndroid.Models;

namespace AppXamAndroid.ViewModels
{
  public  class StudentsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Student student { get; set; }
         

        public StudentsViewModel()
        { }

       
        public Student Student
        {
            get { return this.student; }
            set
            {
                if (!this.student.Equals(value))
                {
                    this.student = value;
                    OnPropertyChanged("Student");
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public static Task<List<Student>> getStudent()
        {
            return Task.Run(() =>
            {
            List<Student> list = new List<Student>();
            int random = new Random().Next(1, 100);

            for (int i = 0; i < random; i++)
            {
                list.Add(new Student { studentName = " Student № " + i });
            }
            return list;
                });
            
        }
    }
}
