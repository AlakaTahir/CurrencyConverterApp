using Converter.Model.ViewModel;
using Converter.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Converter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyInformationController : ControllerBase
    {
        private readonly ICurrencyInformationService _currencyInformationService;
        public CurrencyInformationController(ICurrencyInformationService currencyInformationService)
        {
            _currencyInformationService = currencyInformationService;
        }

        [HttpPost("CreateConverter")]
        public IActionResult CreateCoverter(CurrencyInformationRequestModel model)
        {
            var response = _currencyInformationService.CreateConverter(model);
            return Ok(response);
        }

        [HttpPut("UpdateConverter")]
        public IActionResult UpdateCoverter(Guid id, double toDollarRate)
        {
            var response = _currencyInformationService.UpdateConverter(id, toDollarRate);
            return Ok(response);
        }

        [HttpDelete("DeleteConverter")]
        public IActionResult DeleteConverter(Guid id)
        {
            var response = _currencyInformationService.DeleteConverter(id);
            return Ok(response);
        }

        [HttpGet("GetConverterById")]
        public IActionResult GetConverterById(Guid id)
        {
            var response = _currencyInformationService.GetConverterById(id);
            return Ok(response);
        }

        [HttpGet("GetAllConverter")]
        public IActionResult GetAllConverter()
        {
         var response = _currencyInformationService.GetAllConverter();
         return Ok(response);
        }
    }
}
