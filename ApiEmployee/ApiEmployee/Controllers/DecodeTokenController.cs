using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace ApiEmployee.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DecodeTokenController : ControllerBase
{
    [HttpGet]
    public string GetToken()
    {
        var token = "Bearer eyJhbGciOiJSUzI1NiIsImtpZCI6IkQzQzMwQzhERDg2RTI4NDhCNkUwRDNGMEUyNjY3QzVDQzI0Mzg3RDQiLCJ0eXAiOiJKV1QiLCJ4NXQiOiIwOE1NamRodUtFaTI0TlB3NG1aOFhNSkRoOVEifQ.eyJuYmYiOjE2NzExMTkwOTMsImV4cCI6MTY3MTM3ODI5MywiaXNzIjoiaHR0cHM6Ly9pZC5taXNhLmNvbS52biIsImF1ZCI6Imh0dHBzOi8vaWQubWlzYS5jb20udm4vcmVzb3VyY2VzIiwiY2xpZW50X2lkIjoiOWVlOGVhZTgtZGU0Ny00YThmLWI0MDMtNzM4OWI5OWZhMmIyIiwic3ViIjoiYmI3YmQ2M2EtMmFlMC00NjlhLTk5YzMtZTNiYmE3M2EzYzc2IiwiYXV0aF90aW1lIjoxNjcwOTcyNzMwLCJpZHAiOiJsb2NhbCIsIm1pc2FpZCI6ImJiN2JkNjNhLTJhZTAtNDY5YS05OWMzLWUzYmJhNzNhM2M3NiIsInVzZXJuYW1lIjoibHZ0dW9pQHNvZnR3YXJlLm1pc2EuY29tLnZuIiwiZW1haWwiOiJsdnR1b2lAc29mdHdhcmUubWlzYS5jb20udm4iLCJwaG9uZV9udW1iZXIiOiIiLCJjdWx0dXJlIjoidmktVk4iLCJmaXJzdF9uYW1lIjoiTMOqIFbEg24iLCJsYXN0X25hbWUiOiJUxrDGoWkiLCJzY29wZSI6WyJvcGVuaWQiXSwiYW1yIjpbInB3ZCJdfQ.MQ05yM3cWYz5P-tLYUhNE__v-vPIRWEkxUppm5pp43HKacsd8TQ6hoFkRWhG4YZVccaSrQCuHvssMUhjLLetnVZ46wQ3JKmLdLK2jSKHBso7mtMwWUENsAt6M-XBbl_pZWDYAzd3_L13udUU6cFPeVDZFlByrIq8_31DyRtObiN3cjGbYViLhiCoCTg9arQ_Q3QHCDhnMRHz07vp7k-8w-hYls1d5fpApbzgiL9i52y08fbOiwyvA1uu61vnzozmBmqzYasmHDWfS9CMLQ832F26m3WcZ-RzVJf9xDfVWIbvEF7JSPNJEF7oR4aIssBMxsjn5avCdlTx5SA0ZpRFNA";
        var handler = new JwtSecurityTokenHandler();
        string authHeader = Request.Headers["Authorization"];
        token = token.Replace("Bearer ", "");
        var jwtSecurityToken = handler.ReadJwtToken(token);
        var misaid = jwtSecurityToken.Claims.First(claim => claim.Type == "misaid").Value;

        return misaid;
//        return Get_Payload_JWTToken(token);
    }
    
    public static string Get_Payload_JWTToken(string token)
    {
        var handler = new JwtSecurityTokenHandler();
        var DecodedJWT = handler.ReadJwtToken(token);
        string payload = DecodedJWT.EncodedPayload;  // Gives Payload
        return Encoding.UTF8.GetString(FromBase64Url(payload));
    }
    static byte[] FromBase64Url(string base64Url)
    {
        string padded = base64Url.Length % 4 == 0
        ? base64Url : base64Url + "====".Substring(base64Url.Length % 4);
        string base64 = padded.Replace("_", "/").Replace("-", "+");
        return Convert.FromBase64String(base64);
    }
}
