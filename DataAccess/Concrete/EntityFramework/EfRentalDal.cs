using System;
using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentContext>, IRentalDal
    {
        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
           using(CarRentContext context=new CarRentContext())
            {
                var result=from p in context.Rentals
                           join c in context.Cars
                           on p.CarId equals c.CarId
                           join cst in context.Customers
                           on p.CustomerId equals cst.CustomerId
                           select new RentalDetailDto { CarName=c.CarName, }
            }
        }
    }
}
