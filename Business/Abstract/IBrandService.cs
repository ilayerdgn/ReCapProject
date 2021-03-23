﻿using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {

        IDataResult<List<Brand>> GetAll();
        IResult Add(Brand brand);
        IDataResult<Brand> GetById(int id);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);

    }
}
