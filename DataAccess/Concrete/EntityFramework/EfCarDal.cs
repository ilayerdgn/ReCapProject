using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using(CarRentContext context=new CarRentContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             on p.BrandId equals c.BrandId
                             join cl in context.Colors
                             on p.ColorId equals cl.ColorId
                             select new CarDetailDto { CarId = p.CarId, BrandName = c.BrandName, ColorName=cl.ColorName, DailyPrice=p.DailyPrice };
                return result.ToList();
            }
        }
    }
}
