using BlazorConcepts.Models.ComponentBases;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Components
{
    public partial class BasicComponent : ComponentBase
    {
        [Parameter]
        public RenderFragment ContnetComponent { get; set; }

        [Parameter]
        public ComponentState State { get; set; }

        [Parameter]
        public string ErrorMessage { get; set; }
    }
}
