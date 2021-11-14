using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofact.Exception;
using Core.Aspects.Autofact.Logging;
using Core.Aspects.Autofact.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        [ValidationAspect(typeof(ServiceValidator))]
        [ExceptionLogAspect(typeof(DatabaseLogger))]
        [SecuredOperation("service.add,admin")]
        public IResult Add(Service service)
        {
            ValidationTool.Validate(new ServiceValidator(),service);

            _serviceDal.Add(service);
            return new SuccessResult("Servis eklendi.");
        }

        public IResult Delete(Service service)
        {
            _serviceDal.Delete(service);
            return new SuccessResult("Servis Silindi.");
        }

        public IDataResult<List<Service>> GetAll()
        {
            return new SuccessDataResult<List<Service>>(_serviceDal.GetAll());
        }

        public IDataResult<Service> GetById(int serviceId)
        {
            return new SuccessDataResult<Service>(_serviceDal.Get(p=>p.Id == serviceId));
        }

        public IResult Update(Service service)
        {
            _serviceDal.Update(service);
            return new SuccessResult("Servis güncellendi");
        }
    }
}
