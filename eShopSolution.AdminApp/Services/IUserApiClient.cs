using eShopSolution.ViewModels.System.Users;

namespace eShopSolution.AdminApp.Services
{
	public interface IUserApiClient
	{
		Task<string> Authenticate(LoginRequest request);
	}
}
