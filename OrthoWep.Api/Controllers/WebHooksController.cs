using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using com.orthofeet.Services.Interfaces;
using com.orthofeet.ViewModels.ShipStation;

namespace OrthoWep.Api.Controllers
{
    [Route("api/webhooks/{action}")]
    [ApiController]
    public class WebHooksController : ControllerBase
    {
	    private readonly IShipStationService _shipStationService;
	    public WebHooksController(IShipStationService shipStationService)
	    {
		    _shipStationService = shipStationService;
	    }

	    public JsonResult Ping()
        {
            return new(DateTime.Now);
        }

        [HttpPost]
        public async Task<ActionResult> HandleWebHook(WebHookToken data)
        {
	        await _shipStationService.GetOrder(data.ResourceUrl);
	        return new AcceptedResult();
        }
    }
}
