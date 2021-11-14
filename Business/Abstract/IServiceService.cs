using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IServiceService
    {
        IDataResult<List<Service>> GetAll();
        IDataResult<Service> GetById(int serviceId);
        IResult Add(Service service);
        IResult Update(Service service);
        IResult Delete(Service service);
    }
}
