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
    public class EfCustomerDal :EfEntityRepositoryBase<Customer , RentACarContext> , ICustomerDal
    {
        public List<CustomerDetailDto> GetDetailCustomer()
        {
            using (RentACarContext context =new())
            {
                var result = from customer in context.Customers
                    join user in context.Users on customer.UserId equals user.Id
                    select new CustomerDetailDto
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        CompanyName = customer.CompanyName,
                    };
                return result.ToList();
            }
        }
    }
}
