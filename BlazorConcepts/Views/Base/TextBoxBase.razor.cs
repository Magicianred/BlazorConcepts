using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Base
{
    public partial class TextBoxBase : ComponentBase
    {
        [Parameter]
        public int Count { get; set; }

        [Parameter]
        public RenderFragment MoreThanZero { get; set; }

        [Parameter]
        public RenderFragment ZeroOrBelow { get; set; }

        public RenderFragment GetFragmentBasedOnCount()
        {
            return this.Count switch
            {
                { } when Count > 0 => MoreThanZero,
                _ => ZeroOrBelow
            };
        }
    }
}
