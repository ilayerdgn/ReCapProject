using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IResult Add(Customer customer);
        IDataResult<Customer> GetById(int id);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
    }
}
