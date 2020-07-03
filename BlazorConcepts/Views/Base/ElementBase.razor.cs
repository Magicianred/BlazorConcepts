using BlazorConcepts.Models.ElementBases;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Base
{
    public partial class ElementBase : ComponentBase
    {
        [Parameter]
        public ElementState State { get; set; }

        [Parameter]
        public RenderFragment Loading { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }

        [Parameter]
        public RenderFragment Error { get; set; }


        public RenderFragment GetFragment()
        {
            return this.State switch
            {
                ElementState.Loading => Loading,
                ElementState.Content => Content,
                _ => Error
            };
        }
    }
}
