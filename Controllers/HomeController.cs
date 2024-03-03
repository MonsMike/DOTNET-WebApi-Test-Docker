using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace WebApiTest.Controllers;

[ApiController]
[Route("")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public HttpStatusCode Get()
    {
        return HttpStatusCode.OK;
    }
}