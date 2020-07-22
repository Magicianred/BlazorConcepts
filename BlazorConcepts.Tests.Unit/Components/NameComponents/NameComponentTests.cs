using BlazorConcepts.Models.ComponentBases;
using BlazorConcepts.Services;
using BlazorConcepts.Views.Components;
using Bunit;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Tynamix.ObjectFiller;
using Xunit;

namespace BlazorConcepts.Tests.Unit.Components.NameComponents
{
    public class NameComponentTests : TestContext
    {
        private readonly Mock<IStudentService> studentServiceMock;
        private IRenderedComponent<NameComponent> renderedNameComponent;

        public NameComponentTests()
        {
            this.studentServiceMock = new Mock<IStudentService>();
            Services.AddScoped(service => this.studentServiceMock.Object);
        }

        [Fact]
        public void ShouldInitRendering()
        {
            // given
            ComponentState expectedState = 
                ComponentState.Loading;

            // when 
            var initialNameComponent = new NameComponent();

            // then
            initialNameComponent.State.Should().BeEquivalentTo(expectedState);
            initialNameComponent.TextBox.Should().BeNull();
            initialNameComponent.StudentName.Should().BeNull();
            initialNameComponent.Exception.Should().BeNull();
        }

        [Fact]
        public void ShouldRenderStudentName()
        {
            // given
            ComponentState expectedState = ComponentState.Content;
            string expectedButtonText = "Get Student Name";

            // when
            this.renderedNameComponent = RenderComponent<NameComponent>();

            // then
            this.renderedNameComponent.Instance.StudentName
                .Should().BeNull();

            this.renderedNameComponent.Instance.Button
                .Should().NotBeNull();

            this.renderedNameComponent.Instance.Button.Text
                .Should().Be(expectedButtonText);

            this.renderedNameComponent.Instance.TextBox.GetValue()
                .Should().BeNull();

            this.renderedNameComponent.Instance.State
                .Should().BeEquivalentTo(expectedState);

            this.renderedNameComponent.Instance.Exception
                .Should().BeNull();
        }

        [Fact]
        public void ShouldGetStudentNameWhenButtonIsClickedAndRenderIt()
        {
            // given
            string randomStudentName = new MnemonicString().GetValue();
            string returnedStudentName = randomStudentName;
            string expectedStudentName = returnedStudentName;

            this.studentServiceMock.Setup(service =>
                service.GetStudentName())
                    .Returns(returnedStudentName);

            // when
            this.renderedNameComponent = RenderComponent<NameComponent>();
            this.renderedNameComponent.Instance.Button.Click();

            // then
            this.renderedNameComponent.Instance.TextBox.Value
                .Should().BeEquivalentTo(expectedStudentName);

            this.studentServiceMock.Verify(service =>
                service.GetStudentName(),
                    Times.Once);

            this.studentServiceMock.VerifyNoOtherCalls();
        }
    }
}
