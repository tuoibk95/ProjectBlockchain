using BooksApi.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.IO;
using Newtonsoft.Json;

namespace BooksApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [Route("user/{firstName}")]
    public User GetUser(string firstName)
    {
        using (StreamReader r = new StreamReader("~/mydata/userData.json"))
        {
            string json = r.ReadToEnd();
            User item = JsonConvert.DeserializeObject<User>(json);
        }
        var user = User;
        return user;
    }
}
