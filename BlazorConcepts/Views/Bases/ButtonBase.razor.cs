using System;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Bases
{
    public partial class ButtonBase
    {
        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public Action CallbackFunction { get; set; }

        public void Click() => CallbackFunction.Invoke();
    }
}
