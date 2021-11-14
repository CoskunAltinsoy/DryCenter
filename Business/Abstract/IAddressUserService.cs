using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAddressUserService
    {
        IDataResult<List<AddressUser>> GetAll();
        IDataResult<AddressUser> GetById(int addressUserId);
        IResult Add(AddressUser addressUser);
        IResult Update(AddressUser addressUser);
        IResult Delete(AddressUser addressUser);
    }
}
