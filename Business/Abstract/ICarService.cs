using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IResult Add(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<Car> GetById(int carId);

    }
}
