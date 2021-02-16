using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {

        List<Brand> GetAll();
        void Add(Brand brand);
        Brand GetById(int id);
        void Delete(Brand brand);
        void Update(Brand brand);

    }
}
