using System;
using System.Collections.Generic;
using System.Text;

namespace Converter.Model.ViewModel
{
    public class BaseResponseViewModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public  string Note { get; set; }
    }
}
