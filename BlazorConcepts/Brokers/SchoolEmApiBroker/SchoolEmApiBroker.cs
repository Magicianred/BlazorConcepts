using System.Threading.Tasks;
using RESTFulSense.Clients;

namespace BlazorConcepts.Brokers.SchoolEmApiBroker
{
    public partial class SchoolEmApiBroker : ISchoolEmApiBroker
    {
        private readonly IRESTFulApiFactoryClient apiClient;

        public SchoolEmApiBroker(IRESTFulApiFactoryClient apiClient) => 
           this.apiClient = apiClient;

        private async ValueTask<T> PostAsync<T>(string relativeUrl, T content) =>
            await this.apiClient.PostContentAsync<T>(relativeUrl, content);
    }
}