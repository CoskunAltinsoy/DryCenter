using Core.Utilities.Results;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string email);
        IResult Add(User user);
        IDataResult<User> GetByUserId(int userId);
        IDataResult<List<User>> GetAll();
        IResult Delete(User user);
        IResult Update(User user);
    }
}
