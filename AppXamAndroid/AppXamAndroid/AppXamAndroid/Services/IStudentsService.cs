using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppXamAndroid.Models;

namespace AppXamAndroid.Services
{
    public interface IStudentsService
    {
       Task<List<Student>> GetStudents();
    }
}
