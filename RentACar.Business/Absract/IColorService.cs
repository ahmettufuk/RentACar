﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Core.Utilities.Results;
using RentACar.Entities.Concrete;

namespace RentACar.Business.Absract
{
    public interface IColorService
    {
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
        IDataResult<List<Color>> GetAll();
    }
}
