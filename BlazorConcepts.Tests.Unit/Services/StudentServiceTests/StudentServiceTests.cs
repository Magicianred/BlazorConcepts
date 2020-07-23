using BlazorConcepts.Brokers.Logging;
using BlazorConcepts.Brokers.SchoolEmApiBroker;
using BlazorConcepts.Models.Students;
using BlazorConcepts.Services;
using Moq;
using Tynamix.ObjectFiller;

namespace BlazorConcepts.Tests.Unit.Services.StudentServiceTests
{
    public partial class StudentServiceTests
    {
        private readonly Mock<ISchoolEmApiBroker> schoolEmApiBrokerMock;
        private readonly Mock<ILoggingBroker> loggingBrokerMock;
        private readonly IStudentService studentService;

        public StudentServiceTests()
        {
            this.schoolEmApiBrokerMock = new Mock<ISchoolEmApiBroker>();
            this.loggingBrokerMock = new Mock<ILoggingBroker>();

            this.studentService = new StudentService(
                schoolEmApiBroker: this.schoolEmApiBrokerMock.Object,
                loggingBroker: this.loggingBrokerMock.Object);
        }

        private Student CreateRandomStudent() => new Filler<Student>().Create();
    }
}
