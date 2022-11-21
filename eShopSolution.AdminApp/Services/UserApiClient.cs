using eShopSolution.ViewModels.System.Users;
using Newtonsoft.Json;
using System.Text;

namespace eShopSolution.AdminApp.Services
{
	public class UserApiClient : IUserApiClient
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public UserApiClient(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<string> Authenticate(LoginRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContext = new StringContent(json,Encoding.UTF8,"application/json");
			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("http://localhost:5000");
			var response = await client.PostAsync("/api/users/authenticate",httpContext);
			var token = await response.Content.ReadAsStringAsync();
			return token;
		}
	}
}
