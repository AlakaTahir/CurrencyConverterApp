using System;
using System.Collections.Generic;
using System.Text;

namespace Converter.Model.ViewModel
{
    public class ExchangeRequestModel
    {
     public Guid CurrencyFromId { get; set; } //coreessponding detail
     public Guid CurrencyToId { get; set; }  //coreessponding detail
        public double Amount { get; set; }
    }
}
