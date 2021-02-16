﻿using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int ıd)
        {
            return _colorDal.Get(p => p.ColorId == ıd);
        }

        public void Update(Color color)
        {
             _colorDal.Update(color);
        }
    }
}