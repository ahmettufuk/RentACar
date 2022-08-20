using RentACar.DataAcces.Absract;
using RentACar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RentACar.Core.DataAccess.EntityFramework;
using RentACar.Entities.DTOs;

namespace RentACar.DataAcces.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext> , ICarDal
    {
        public List<CarDetails> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {

                var result = from car in context.Cars
                    join color in context.Colors on car.ColorId equals color.ColorId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    select new CarDetails
                    {
                        CarName = car.CarName,
                        ColorName = color.ColorName,
                        BrandName = brand.BrandName,
                        DailyPrice = car.DailyPrice,
                    };

                return result.ToList();

            }
        }

        public List<CarDetailForListAngularDto> GetCarDetailForListAngular()
        {
            using (RentACarContext context = new())
            {
                var result = from car in context.Cars
                    join color in context.Colors on car.ColorId equals color.ColorId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    select new CarDetailForListAngularDto
                    {
                        Id = car.Id,
                        BrandId = brand.BrandId,
                        ColorId = color.ColorId,
                        CarName = car.CarName,
                        ColorName = color.ColorName,
                        BrandName = brand.BrandName,
                        Description = car.Description,
                        DailyPrice = car.DailyPrice,
                        ModelYear = car.ModelYear
                    };
                return result.ToList();
            }
        }
    }
}
