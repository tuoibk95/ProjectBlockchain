using System;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.System.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace eShopSolution.Application.System.Users
{
	public class UserService : IUserService
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;
		private readonly RoleManager<AppRole> _roleManager;
		private readonly IConfiguration _config;
		public UserService(UserManager<AppUser> userUManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, IConfiguration config)
		{
			_userManager = userUManager;
			_signInManager = signInManager;
			_roleManager = roleManager;
			_config = config;
		}
		public async Task<string> Authencate(LoginRequest request)
		{
			var user = await _userManager.FindByNameAsync(request.UserName);
			if (user == null) return null;
			var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
			if (!result.Succeeded)
			{
				return null;
			}
			var roles = _userManager.GetRolesAsync(user);
			var claims = new[]
			{
				new Claim(ClaimTypes.Email,user.Email),
				new Claim(ClaimTypes.GivenName, user.FirstName),
				new Claim(ClaimTypes.Role,string.Join(";", roles)),
				new Claim(ClaimTypes.Name,user.UserName),
			};
			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			var token = new JwtSecurityToken(_config["Tokens:Issuer"],
				_config["Tokens:Issuer"],
				claims,
				expires : DateTime.Now.AddHours(3),
				signingCredentials: creds);
			return new JwtSecurityTokenHandler().WriteToken(token);
		}

		public async Task<bool> Register(RegisterRequest request)
		{
			var user = new AppUser()
			{
				UserName = request.UserName,
				Email = request.Email,
				Dob = request.Dob,
				FirstName = request.FirstName,
				LastName = request.LastName,
				PhoneNumber = request.PhoneNumber
			};
			var result = await _userManager.CreateAsync(user,request.Password);
			if (result.Succeeded)
			{
				return true;
			}
			return false;
		}
	}
}
