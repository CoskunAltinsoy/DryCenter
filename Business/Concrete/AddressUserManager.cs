using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AddressUserManager : IAddressUserService
    {
        IAddressUserDal _addressUserDal;
        public AddressUserManager(IAddressUserDal addressUserDal)
        {
            _addressUserDal = addressUserDal;
        }
        public IResult Add(AddressUser addressUser)
        {
            _addressUserDal.Add(addressUser);
            return new SuccessResult();
        }

        public IResult Delete(AddressUser addressUser)
        {
            _addressUserDal.Delete(addressUser);
            return new SuccessResult();
        }

        public IDataResult<List<AddressUser>> GetAll()
        {
            return new SuccessDataResult<List<AddressUser>>(_addressUserDal.GetAll());
        }

        public IDataResult<AddressUser> GetById(int addressUserId)
        {
            return new SuccessDataResult<AddressUser>(_addressUserDal.Get(a => a.Id == addressUserId));
        }

        public IResult Update(AddressUser addressUser)
        {
            _addressUserDal.Add(addressUser);
            return new SuccessResult();
        }
    }
}
