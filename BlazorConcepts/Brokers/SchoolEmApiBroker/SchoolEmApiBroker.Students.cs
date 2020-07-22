using System.Threading.Tasks;
using BlazorConcepts.Models.Students;

namespace BlazorConcepts.Brokers.SchoolEmApiBroker
{
    public partial class SchoolEmApiBroker
    {
        private const string RelativeUrl = "api/students";

        public async ValueTask<Student> PostStudentAsync(Student student) =>
            await PostAsync(RelativeUrl, student);
    }
}
