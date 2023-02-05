using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Converter.Model.Entity
{
    public class CurrencyInfo
    {
        public Guid Id { get; set; }
        public string CurrencyName { get; set; }
      
        [StringLength(3)]
        public string CurrencySymbol { get; set; }  //database.Symbol == request.Symbol || database.Name.Contains(request.Name)

        public double ToDollarRate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
