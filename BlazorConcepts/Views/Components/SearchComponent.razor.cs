using System;
using System.Threading.Tasks;
using BlazorConcepts.Models.ElementBases;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Views.Components
{
    public partial class SearchComponent : ComponentBase
    {
        public ElementState State { get; set; }

        protected async override Task OnInitializedAsync()
        {
            try
            {
                await Task.Delay(3000);
                State = ElementState.Content;
                await Task.Delay(3000);
                throw new Exception();
            }
            catch (Exception exception)
            {
                State = ElementState.Error;
            }
        }
    }
}
