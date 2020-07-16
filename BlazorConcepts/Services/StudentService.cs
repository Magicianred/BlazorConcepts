using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorConcepts.Services
{
    public class StudentService : IStudentService
    {
        public string GetStudentName() => "Jackie Lee";
    }
}
