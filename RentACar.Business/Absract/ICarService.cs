using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Core.Utilities.Results;
using RentACar.Entities.Concrete;
using RentACar.Entities.DTOs;

namespace RentACar.Business.Absract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetails>> GetCarDetails();
        IDataResult<List<CarDetailForListAngularDto>> GetCarDetailForListAngular();
        IDataResult<List<CarDetailForListAngularDto>> GetCarDetailsByBrandId(int brandId);
        IDataResult<List<CarDetailForListAngularDto>> GetCarDetailsByColourId(int colourId);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);

    }
}
