using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Bases
{
    public partial class TextBoxBase
    {
        [Parameter]
        public string Value { get; set; }

        public string GetValue() => this.Value;
    }
}
