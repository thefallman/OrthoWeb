using System;
using Microsoft.AspNetCore.Mvc;

namespace OrthoWeb.Controllers.api
{
    [Route("api/webhooks/{action}")]
    [ApiController]
    public class WebHooksController : ControllerBase
    {
        public JsonResult Ping()
        {
            return new($"Now is: {DateTime.Now}");
        }
    }
}