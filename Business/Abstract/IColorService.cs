using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        void Add(Color color);
        Color GetById(int ıd);
        void Delete(Color color);
        void Update(Color color);
    }
}
