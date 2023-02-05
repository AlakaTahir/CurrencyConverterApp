using Arch.EntityFrameworkCore.UnitOfWork;
using Converter.Model.Entity;
using Converter.Model.ViewModel;
using Converter.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Converter.Service.Service
{
    public class CurrencyInformationService : ICurrencyInformationService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CurrencyInformationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public BaseResponseViewModel CreateConverter (CurrencyInformationRequestModel model) 
        {
            var converter = _unitOfWork.GetRepository<CurrencyInfo>().GetFirstOrDefault(predicate: y=> y.CurrencySymbol == model.CurrencySymbol || y.CurrencyName.Contains(model.CurrencyName));
            if (converter == null)
            {
                var info = new CurrencyInfo();
                info.Id = Guid.NewGuid();
                info.CurrencySymbol = model.CurrencySymbol;
                info.CurrencyName = model.CurrencyName;
                info.ToDollarRate = model.ToDollarRate;
                info.CreatedDate = DateTime.Now;

                return new BaseResponseViewModel 
                {
                    Message = "Created Successfully",
                    Status = true
                };


            }
            else
            {
                return new BaseResponseViewModel
                {
                    Message = "Currency already exist",
                    Status = false
                };
            }
        }
        
        public BaseResponseViewModel UpdateConverter (Guid id, double toDollarRate) 
        {
            var converter = _unitOfWork.GetRepository<CurrencyInfo>().GetFirstOrDefault(predicate: y => y.Id == id);
            
            if (converter != null) 
            { 
                converter.ToDollarRate = toDollarRate;
                
                _unitOfWork.GetRepository<CurrencyInfo>().Update(converter);
                _unitOfWork.SaveChanges();

                return new BaseResponseViewModel 
                { 
                 Message = "Updated Successfully",
                 Status = true,
                
                };
            }

            else
            {
                return new BaseResponseViewModel 
                {                  
                  Message = "UnSuccessful",
                  Status = false,
                  
                };
            } 
            
        }

        public BaseResponseViewModel DeleteConverter (Guid id) 
        { 
              var Converter = _unitOfWork.GetRepository<CurrencyInfo>().GetFirstOrDefault(predicate: x => x.Id == id);
              if (Converter != null) 
              {
                _unitOfWork.GetRepository<CurrencyInfo>().Delete(Converter);
                _unitOfWork.SaveChanges();

                return new BaseResponseViewModel 
                {
                    Message = "Deleted Successfully",
                    Status = true,
                };
              }
              else 
              {
                return new BaseResponseViewModel
                { 
                    Message = "It does not exist",
                    Status = false,
                };

              }
        }
        public CurrencyInformationResponseViewModel GetConverterById (Guid id) 
        {
            var converter = _unitOfWork.GetRepository<CurrencyInfo>().GetFirstOrDefault(predicate: y => y.Id == id);
            if (converter != null)
            {
                return new CurrencyInformationResponseViewModel
                { 
                 Id = converter.Id,
                 CurrencyName = converter.CurrencyName,
                 CurrencySymbol = converter.CurrencySymbol,
                 ToDollarRate = converter.ToDollarRate,
                };
            }
            else 
            {
                return null;
            };
        }
        public List<CurrencyInformationResponseViewModel> GetAllConverter() 
        {
            var converters = _unitOfWork.GetRepository<CurrencyInfo>().GetAll().ToList();
             if (converters.Count != 0)
            {
                var response = new List<CurrencyInformationResponseViewModel>();
                foreach (var converter in converters) 
                {
                    var singleModel = new CurrencyInformationResponseViewModel();
                    singleModel.CurrencyName = converter.CurrencyName;
                    singleModel.CurrencySymbol = converter.CurrencySymbol;
                    singleModel.ToDollarRate = converter.ToDollarRate;
                    singleModel.Id = converter.Id;
                    
                    response.Add(singleModel);
                    
                }
                return response;

            }
             else 
            { 
                return null;
            }
        }
    }
}
