using System;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Bases
{
    public partial class ButtonBase : IButtonBase
    {
        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public Action CallbackFunction { get; set; }

        public void Click() => CallbackFunction.Invoke();
    }

    public interface IButtonBase
    {
        public void Click();
    }
}
