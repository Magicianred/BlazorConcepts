using System;
using System.Threading.Tasks;
using BlazorConcepts.Brokers.Logging;
using BlazorConcepts.Brokers.SchoolEmApiBroker;
using BlazorConcepts.Models.Students;

namespace BlazorConcepts.Services
{
    public class StudentService : IStudentService
    {
        private readonly ISchoolEmApiBroker schoolEmApiBroker;
        private readonly ILoggingBroker loggingBroker;

        public StudentService(
            ISchoolEmApiBroker schoolEmApiBroker,
            ILoggingBroker loggingBroker)
        {
            this.schoolEmApiBroker = schoolEmApiBroker;
            this.loggingBroker = loggingBroker;
        }

        public async ValueTask<Student> RegisterStudentAsync(Student student) =>
            await this.schoolEmApiBroker.PostStudentAsync(student);
    }
}
