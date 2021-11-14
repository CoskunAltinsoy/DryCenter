using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal;
        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }
        public IResult Add(Country country)
        {
            _countryDal.Add(country);
            return new SuccessResult();
        }

        public IResult Delete(Country country)
        {
            _countryDal.Delete(country);
            return new SuccessResult();
        }

        public IDataResult<List<Country>> GetAll()
        {
            return new SuccessDataResult<List<Country>>(_countryDal.GetAll());
        }

        public IDataResult<Country> GetById(int countryId)
        {
            return new SuccessDataResult<Country>(_countryDal.Get(c=>c.Id == countryId));
        }

        public IResult Update(Country country)
        {
            _countryDal.Update(country);
            return new SuccessResult();
        }
    }
}
