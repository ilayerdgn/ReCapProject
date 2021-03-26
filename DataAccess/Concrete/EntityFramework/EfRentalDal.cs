using System;
using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
           using(CarRentContext context=new CarRentContext())
            {
                var result = from p in context.Rentals
                             join c in context.Cars on p.CarId equals c.CarId
                             join cst in context.Customers on p.CustomerId equals cst.CustomerId
                             join brnd in context.Brands on c.BrandId equals brnd.BrandId
                             join usr in context.Users on cst.UserId equals usr.UserId

                             select new RentalDetailDto
                             {
                                 RentalId = p.RentalId,
                                 CarName = brnd.BrandName,
                                 CustomerName = usr.FirstName,
                                 CustomerSurname = usr.LastName,
                                 RentDate = p.RentDate,
                                 ReturnDate = p.ReturnDate
                             };


                return result.ToList();
            }
        }
    }
}
