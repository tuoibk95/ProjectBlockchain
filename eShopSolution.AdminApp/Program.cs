using eShopSolution.AdminApp.Services;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>
{
	option.LoginPath = "/User/Login";
	option.AccessDeniedPath = "/User/Forbidden/";
});

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IUserApiClient, UserApiClient>();
#region Add runtime khi sửa đổi có thể update được ngay trên browser
IMvcBuilder build =  builder.Services.AddRazorPages();
var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
#if DEBUG
if (enviroment == Environments.Development)
{
	build.AddRazorRuntimeCompilation();
}
#endif
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
