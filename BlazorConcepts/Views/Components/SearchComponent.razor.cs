using System;
using System.Threading.Tasks;
using BlazorConcepts.Models.ComponentBases;
using BlazorConcepts.Models.Students.Exceptions;
using BlazorConcepts.Services;
using BlazorConcepts.Views.Bases;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Components
{
    public partial class SearchComponent : ComponentBase
    {
        [Inject]
        public IStudentService StudentService { get; set; }

        public ComponentState State { get; set; }
        public SearchComponentException Exception { get; set; }
        public string StudentName { get; set; }
        public LabelBase Label { get; set; }

        protected override void OnInitialized()
        {
            try
            {
                this.StudentName = this.StudentService.GetStudentName();
                this.State = ComponentState.Content;
            }
            catch (Exception exception)
            {
                this.Exception = new SearchComponentException(exception);
                this.State = ComponentState.Error;
            }
        }
    }
}
