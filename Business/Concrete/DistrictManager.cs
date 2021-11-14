using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;
        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }
        public IResult Add(District district)
        {
            _districtDal.Add(district);
            return new SuccessResult();
        }

        public IResult Delete(District district)
        {
            _districtDal.Delete(district);
            return new SuccessResult();
        }

        public IDataResult<List<District>> GetAll()
        {
            return new SuccessDataResult<List<District>>(_districtDal.GetAll());
        }

        public IDataResult<District> GetById(int districtId)
        {
            return new SuccessDataResult<District>(_districtDal.Get(d => d.Id == districtId));
        }

        public IResult Update(District district)
        {
            _districtDal.Update(district);
            return new SuccessResult();
        }
    }
}
