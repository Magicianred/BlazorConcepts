using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorConcepts.Models.ComponentBases;
using BlazorConcepts.Models.NameComponents.Exceptions;
using BlazorConcepts.Services;
using BlazorConcepts.Views.Bases;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Components
{
    public partial class NameComponent
    {
        [Inject]
        public IStudentService StudentService { get; set; }

        public ComponentState State { get; set; }
        public NameComponentException Exception { get; set; }
        public string StudentName { get; set; }
        public TextBoxBase TextBox { get; set; }

        protected override void OnInitialized()
        {
            this.StudentName = this.StudentService.GetStudentName();
            this.State = ComponentState.Content;
        }
    }
}
