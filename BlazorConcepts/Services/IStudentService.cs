using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorConcepts.Models.Students;

namespace BlazorConcepts.Services
{
    public interface IStudentService
    {
        ValueTask<Student> RegisterStudentAsync(Student student);
    }
}
