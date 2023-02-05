using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Converter.Model.ViewModel
{
    public class CurrencyInformationRequestModel
    {
        public string CurrencyName { get; set; }
        
        [StringLength(3)]
        public string CurrencySymbol { get; set; }
        public double ToDollarRate { get; set; }
        
    }
}
