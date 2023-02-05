using Converter.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Converter.Service.Interface
{
    public interface ICurrencyInformationService
    {
        BaseResponseViewModel CreateConverter(CurrencyInformationRequestModel model);
        public BaseResponseViewModel UpdateConverter(Guid id, double toDollarRate);
        public BaseResponseViewModel DeleteConverter(Guid id);
        CurrencyInformationResponseViewModel GetConverterById(Guid id);
        List<CurrencyInformationResponseViewModel> GetAllConverter();




    }
}
