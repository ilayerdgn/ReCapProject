using System;
using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByColorId(int id);
        List<Car> GetCarsByBrandId(int id);
        void Add(Car car);
        List<CarDetailDto> GetCarDetails();
        void Delete(Car car);
        void Update(Car car);

    }
}
