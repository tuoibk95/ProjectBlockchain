namespace BooksApi;

public static class RegisterServices
{
    public static void ConfigurationServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddMemoryCache();

        builder.Services.AddSingleton<IDBConnection, DBConnection>();
        builder.Services.AddSingleton<ICategoryData, MongoCategoryData>();
    }
}
