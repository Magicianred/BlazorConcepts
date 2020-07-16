using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Bases
{
    public partial class LabelBase
    {
        [Parameter]
        public string Value { get; set; }

        [Parameter]
        public string Styles { get; set; }
    }
}
