using BlazorConcepts.Models.ComponentBases;
using BlazorConcepts.Services;
using BlazorConcepts.Views.Components;
using Bunit;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace BlazorConcepts.Tests.Unit.Components.RegisterStudentComponentTests
{
    public class RegisterStudentComponentTests : TestContext
    {
        private readonly Mock<IStudentService> studentServiceMock;

        public RegisterStudentComponentTests()
        {
            this.studentServiceMock = new Mock<IStudentService>();
            Services.AddScoped(provider => this.studentServiceMock.Object);
        }

        [Fact]
        public void ShouldRenderOnInit()
        {
            // given
            ComponentState expectedComponentState = ComponentState.Loading;

            // when 
            var initialStudentRegisterComponent = new RegisterStudentComponent();

            // then
            initialStudentRegisterComponent.State.Should().BeEquivalentTo(expectedComponentState);
            initialStudentRegisterComponent.Student.Should().BeNull();
            initialStudentRegisterComponent.StudentNameTextBox.Should().BeNull();
        }
    }
}
