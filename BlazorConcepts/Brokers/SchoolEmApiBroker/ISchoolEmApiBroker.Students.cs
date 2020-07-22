using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorConcepts.Models.Students;

namespace BlazorConcepts.Brokers.SchoolEmApiBroker
{
    public partial interface ISchoolEmApiBroker
    {
        ValueTask<Student> PostStudentAsync(Student student);
    }
}
