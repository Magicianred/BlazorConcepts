using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Pages
{
    public partial class SearchPage : ComponentBase
    {
        [Parameter]
        public string MyParameter { get; set; }
    }
}
