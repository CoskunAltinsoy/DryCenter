using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDistrictService
    {
        IDataResult<List<District>> GetAll();
        IDataResult<District> GetById(int districtId);
        IResult Add(District district);
        IResult Update(District district);
        IResult Delete(District district);
    }
}
