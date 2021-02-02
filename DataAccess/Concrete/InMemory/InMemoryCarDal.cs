using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {

                new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice=10000, ModelYear=2000, Description="tanım1"},
                new Car{CarId=2, BrandId=2, ColorId=5, DailyPrice=100000, ModelYear=2020, Description="tanım2"},
                new Car{CarId=3, BrandId=5, ColorId=4, DailyPrice=11000, ModelYear=2010, Description="tanım3"},
                new Car{CarId=4, BrandId=1, ColorId=3, DailyPrice=30000, ModelYear=2004, Description="tanım4"},
                new Car{CarId=5, BrandId=2, ColorId=2, DailyPrice=500000, ModelYear=2002, Description="tanım5"},
                new Car{CarId=6, BrandId=3, ColorId=2, DailyPrice=20000, ModelYear=1998, Description="tanım6"},
                new Car{CarId=7, BrandId=4, ColorId=1, DailyPrice=45000, ModelYear=1995, Description="tanım7"}
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(CarToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(p => p.CarId == CarId).ToList();

        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ModelYear = car.ModelYear;

        }
    }
}
