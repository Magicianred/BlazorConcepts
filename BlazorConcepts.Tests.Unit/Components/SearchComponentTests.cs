using System;
using BlazorConcepts.Models.ComponentBases;
using BlazorConcepts.Models.Students.Exceptions;
using BlazorConcepts.Services;
using BlazorConcepts.Views.Components;
using Bunit;
using Bunit.Mocking.JSInterop;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Tynamix.ObjectFiller;
using Xunit;

namespace BlazorConcepts.Tests.Unit
{
    public class SearchComponentTests : TestContext
    {
        private readonly Mock<IStudentService> studentServiceMock;
        private IRenderedComponent<SearchComponent> searchComponent;

        public SearchComponentTests()
        {
            this.studentServiceMock = new Mock<IStudentService>();
            Services.AddScoped(provider => this.studentServiceMock.Object);
            
        }

        [Fact]
        public void ShouldRenderOnInit()
        {
            // given
            ComponentState expectedState = ComponentState.Loading;

            // when
            var preRenderComponent = new SearchComponent();

            // then
            preRenderComponent.State.Should()
                .BeEquivalentTo(expectedState);

            preRenderComponent.Exception.Should().BeNull();
            preRenderComponent.StudentName.Should().BeNull();
        }

        [Fact]
        public void ShouldRenderStudentName()
        {
            // given
            ComponentState expectedState = ComponentState.Content;
            string randomStudentName = new MnemonicString().GetValue();
            string returnedStudentName = randomStudentName;
            string expectedStudentName = returnedStudentName;

            this.studentServiceMock.Setup(service =>
                service.GetStudentName())
                    .Returns(returnedStudentName);

            // when 
            this.searchComponent = RenderComponent<SearchComponent>();

            //then
            this.searchComponent.Instance.StudentName.Should()
                .BeEquivalentTo(expectedStudentName);

            this.searchComponent.Instance.State.Should()
                .BeEquivalentTo(expectedState);

            this.searchComponent.Instance.Exception.Should().BeNull();

            this.studentServiceMock.Verify(service =>
                service.GetStudentName(),
                    Times.Once);

            this.studentServiceMock.VerifyNoOtherCalls();
        }

        [Fact]
        public void ShouldDisplayErrorOnRenderIfExceptionOccurs()
        {
            // given
            var someException = new Exception();
            var expectedException = new SearchComponentException(someException);
            ComponentState expectedState = ComponentState.Error;

            this.studentServiceMock.Setup(service =>
                service.GetStudentName())
                    .Throws(someException);

            // when 
            this.searchComponent = RenderComponent<SearchComponent>();

            // then
            this.searchComponent.Instance.State.Should().BeEquivalentTo(expectedState);
            this.searchComponent.Instance.Exception.Should().BeEquivalentTo(expectedException);
            this.searchComponent.Instance.StudentName.Should().BeNull();

            this.studentServiceMock.Verify(service =>
                service.GetStudentName(),
                    Times.Once);

            this.studentServiceMock.VerifyNoOtherCalls();
        }
    }
}
