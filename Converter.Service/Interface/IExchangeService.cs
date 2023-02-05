using Converter.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Converter.Service.Interface
{
    public interface IExchangeService
    {
        ExchangeResponseViewModel CalculateExchange(ExchangeRequestModel model);

    }
}
