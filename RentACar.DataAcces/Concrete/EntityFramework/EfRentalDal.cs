using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Core.DataAccess.EntityFramework;
using RentACar.DataAcces.Absract;
using RentACar.Entities.Concrete;
using RentACar.Entities.DTOs;

namespace RentACar.DataAcces.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental,RentACarContext> , IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailsDto()
        {
            using (RentACarContext context = new())
            {
                var result = from rental in context.Rentals
                    join car in context.Cars on rental.CarId equals car.Id
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join customer in context.Customers on rental.CustomerId equals customer.Id
                    join user in context.Users on customer.UserId equals user.Id
                    select new RentalDetailDto
                    {
                        BrandName = brand.BrandName,
                        CustomerFirstName = user.FirstName,
                        CustomerLastName = user.LastName,
                        RentDate = rental.RentDate,
                        ReturnDate = rental.ReturnDate
                    };
                return result.ToList();
            }
        }
    }
}
