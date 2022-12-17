using ApiEmployee.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiEmployee.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [Route("user/{firstName}")]
    [HttpGet]
    public JsonResult GetUser(string firstName)
    {
        UserJson item;
        using (StreamReader r = new StreamReader("../user.json"))
        {
            string json = r.ReadToEnd();
            item = JsonConvert.DeserializeObject<UserJson>(json);
            foreach(var user in item.Users)
            {
                if (user.FirstName.ToLower() == firstName)
                {
                    return new JsonResult(user);
                }
            }
        }
        return new JsonResult(null);
    }
}
