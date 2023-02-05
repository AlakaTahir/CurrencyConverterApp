using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Converter.Model.ViewModel
{
    public class CurrencyInformationResponseViewModel
    {
     public Guid Id { get; set; }
     public string CurrencyName { get; set; }
     [StringLength(1)]
     public string CurrencySymbol { get; set; }
     public double ToDollarRate { get; set; }
    }
}
