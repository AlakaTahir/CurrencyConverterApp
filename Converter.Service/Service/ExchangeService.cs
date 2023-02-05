using Arch.EntityFrameworkCore.UnitOfWork;
using Converter.Model.Entity;
using Converter.Model.ViewModel;
using Converter.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Converter.Service.Service
{
    public class ExchangeService : IExchangeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ExchangeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
        }
        public ExchangeResponseViewModel CalculateExchange (ExchangeRequestModel model)
        {
            var currencyFromDetail = _unitOfWork.GetRepository<CurrencyInfo>().GetFirstOrDefault(predicate: x => x.Id == model.CurrencyFromId);
            var currencyToDetail = _unitOfWork.GetRepository<CurrencyInfo>().GetFirstOrDefault(predicate: x => x.Id == model.CurrencyToId);
            double answer = 0;

            if (currencyToDetail.CurrencySymbol.ToUpper() == "USD")
            {            
                answer = model.Amount/currencyFromDetail.ToDollarRate;
                return new ExchangeResponseViewModel
                {
                    Answer = answer,
                    Status = true,
                    Message = "Operation Successful"
                };
            }
            else
            {
                //ngn ==> pounds  ngn ==> usd   2usd ==>  2 * 0.9pound
                var dollarAmount = model.Amount / currencyFromDetail.ToDollarRate;
                answer = dollarAmount * currencyToDetail.ToDollarRate;

                return new ExchangeResponseViewModel
                {
                    Answer = answer,
                    Status = true,
                    Message = "Operation Successful"
                };
            }

            //var convertToDollar = model.Amount * model.ToDollarRate;
            //var ExchangeRate = model.Amount * convertToDollar;

        }

    }
}
