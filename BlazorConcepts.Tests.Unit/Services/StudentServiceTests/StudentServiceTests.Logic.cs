using System.Threading.Tasks;
using BlazorConcepts.Models.Students;
using FluentAssertions;
using Moq;
using Xunit;

namespace BlazorConcepts.Tests.Unit.Services.StudentServiceTests
{
    public partial class StudentServiceTests
    {
        [Fact]
        public async Task ShouldSubmitStudentAsync()
        {
            // given
            Student randomStudent = CreateRandomStudent();
            Student inputStudent = randomStudent;
            Student returnedStudent = inputStudent;
            Student expectedStudent = returnedStudent;

            this.schoolEmApiBrokerMock.Setup(service =>
                service.PostStudentAsync(inputStudent))
                    .ReturnsAsync(returnedStudent);

            // when
            Student actualStudent =
                await this.studentService.RegisterStudentAsync(inputStudent);

            // then
            actualStudent.Should().BeEquivalentTo(expectedStudent);

            this.schoolEmApiBrokerMock.Verify(broker =>
                broker.PostStudentAsync(inputStudent),
                    Times.Once);

            this.schoolEmApiBrokerMock.VerifyNoOtherCalls();
            this.loggingBrokerMock.VerifyNoOtherCalls();
        }
    }
}
