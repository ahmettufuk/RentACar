using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Entities.Concrete;
using RentACar.Entities.DTOs;

namespace RentACar.DataAcces.Absract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetails> GetCarDetails();
    }
}
