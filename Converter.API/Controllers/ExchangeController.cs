using Converter.Model.ViewModel;
using Converter.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Converter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeController : ControllerBase
    {
        private readonly IExchangeService _exchangeService;
        public ExchangeController(IExchangeService exchangeService)
        {
            _exchangeService = exchangeService;
        }
        [HttpGet("CalculateExchange")]
        public IActionResult CalculateExchange(ExchangeRequestModel model) 
        { 
          var response = _exchangeService.CalculateExchange(model);
          return Ok(response);
        }


    }
}
