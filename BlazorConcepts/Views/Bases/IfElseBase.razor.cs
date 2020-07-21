using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Bases
{
    public partial class IfElseBase
    {
        [Parameter]
        public bool Condition { get; set; }

        [Parameter]
        public RenderFragment TrueFragment { get; set; }

        [Parameter]
        public RenderFragment FalseFragment { get; set; }


        public RenderFragment GetFragment()
        {
            return this.Condition switch
            {
                true => TrueFragment,
                false => FalseFragment
            };
        }
    }
}
