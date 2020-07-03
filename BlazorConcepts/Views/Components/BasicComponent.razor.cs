using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorConcepts.Models.ElementBases;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Components
{
    public partial class BasicComponent : ComponentBase
    {
        [Parameter]
        public RenderFragment ContnetComponent { get; set; }

        [Parameter]
        public ElementState State { get; set; }

        [Parameter]
        public string ErrorMessage { get; set; }
    }
}
