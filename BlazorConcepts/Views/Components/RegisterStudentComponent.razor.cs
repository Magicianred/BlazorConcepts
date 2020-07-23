using BlazorConcepts.Models.ComponentBases;
using BlazorConcepts.Models.Students;
using BlazorConcepts.Services;
using BlazorConcepts.Views.Bases;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Components
{
    public partial class RegisterStudentComponent
    {
        [Inject]
        public IStudentService StudentService { get; set; }

        public TextBoxBase StudentNameTextBox { get; set; }
        public Student Student { get; set; }
        public ComponentState State { get; set; }
    }
}
