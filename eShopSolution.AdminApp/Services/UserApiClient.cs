using eShopSolution.ViewModels.System.Users;
using Newtonsoft.Json;
using System.Text;

namespace eShopSolution.AdminApp.Services
{
	public class UserApiClient : IUserApiClient
	{
		// A factory abstraction for a component that can create System.Net.Http.HttpClient instances with custom configuration for a given logical name.
		// Remarks:
		//     A default System.Net.Http.IHttpClientFactory can be registered in an Microsoft.Extensions.DependencyInjection.IServiceCollection
		//     by calling Microsoft.Extensions.DependencyInjection.HttpClientFactoryServiceCollectionExtensions.AddHttpClient(Microsoft.Extensions.DependencyInjection.IServiceCollection).
		//     The default System.Net.Http.IHttpClientFactory will be registered in the service collection as a singleton.
		private readonly IHttpClientFactory _httpClientFactory;
		public UserApiClient(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<string> Authenticate(LoginRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json,Encoding.UTF8,"application/json");
			//
			// Summary: Creates a new System.Net.Http.HttpClient using the default configuration.
			// Parameters:
			//   factory: The System.Net.Http.IHttpClientFactory.
			// Returns: An System.Net.Http.HttpClient configured using the default configuration.
			var client = _httpClientFactory.CreateClient();
			// Summary: Gets or sets the base address of Uniform Resource Identifier (URI) of the Internet resource used when sending requests.
			// Returns: The base address of Uniform Resource Identifier (URI) of the Internet resource used when sending requests.
			client.BaseAddress = new Uri("http://localhost:5000");
			var response = await client.PostAsync("/api/users/authenticate",httpContent);
			var token = await response.Content.ReadAsStringAsync();
			return token;
		}
	}
}
