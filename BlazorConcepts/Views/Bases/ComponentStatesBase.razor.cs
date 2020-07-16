using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorConcepts.Models.ComponentBases;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Bases
{
    public partial class ComponentStatesBase
    {

        [Parameter]
        public ComponentState State { get; set; }

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
                ComponentState.Loading => Loading,
                ComponentState.Content => Content,
                _ => Error
            };
        }
    }
}
