﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int colorid);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
        
        

    }
}
